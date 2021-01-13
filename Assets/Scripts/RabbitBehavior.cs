using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitBehavior : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float range;
    [SerializeField] float maxDistance;
    [SerializeField] public float hearingRadius;
    float currentSpeed;
    public Vector3 waypoint;
    [SerializeField] bool isFleeing = false;

    public LayerMask targetMask;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = speed;
        SetNewDest();
    }

    // Update is called once per frame
    void Update()
    {
        TargetsInFOV();
        TargetsInHearingRange();
        if (isFleeing)
        {
            UpdateRabbitFlee();
        }
        else
        {
            UpdateWander();
        }
    }

    void SetNewDest()
    {
        waypoint = new Vector3(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }

    void UpdateWander()
    {
        currentSpeed = speed;
        transform.position = Vector2.MoveTowards(transform.position, waypoint, currentSpeed * Time.deltaTime);
        RotateTowards(waypoint);

        if (Vector2.Distance(transform.position, waypoint) < range)
            SetNewDest();
    }
    void UpdateRabbitFlee()
    {
        currentSpeed = maxSpeed;

        //transform.position = Vector2.MoveTowards(transform.position, waypoint, -1 * currentSpeed * Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position, waypoint, -1 * currentSpeed * Time.deltaTime);
        Vector3 vectorFromTarget = transform.position - waypoint;
        RotateTowards(vectorFromTarget);
    }

    void TargetsInFOV()
    {
        FOV[] eyes = GetComponentsInChildren<FOV>();
        List<Transform> targets = new List<Transform>();//GetComponentInChildren<FOV>().visibleTargets;
        for (int i = 0; i < eyes.Length; i++)
        {
            List<Transform> t = eyes[i].visibleTargets;
            for (int j = 0; j < t.Count; j++)
            {
                targets.Add(t[j]);
            }
        }

        int targetCount = targets.Count;
        if (targetCount > 0)
        {
            for (int i = 0; i < targetCount; i++)
            {
                waypoint += targets[i].position;
            }
            waypoint /= targetCount;
            isFleeing = true;
        }
    }

    void TargetsInHearingRange()
    {
        Collider2D[] targetsInHearingRadius = Physics2D.OverlapCircleAll(transform.position, hearingRadius, targetMask);
        if (isFleeing && targetsInHearingRadius.Length == 0)
        {
            isFleeing = false;
            SetNewDest();
        }
    }

    void RotateTowards(Vector3 target)
    {
        Vector3 vectorToTarget = target - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        const float angleSpeed = 10f;
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * angleSpeed);
    }
}

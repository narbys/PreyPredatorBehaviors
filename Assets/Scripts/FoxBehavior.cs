using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxBehavior : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float range;
    [SerializeField] float maxDistance;
    float currentSpeed;

    public Vector3 waypoint;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = speed;
        SetNewDest();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWander();
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
    void RotateTowards(Vector3 target)
    {
        Vector3 vectorToTarget = target - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        const float angleSpeed = 10f;
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * angleSpeed);
    }
}

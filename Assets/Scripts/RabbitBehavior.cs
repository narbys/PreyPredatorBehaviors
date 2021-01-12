using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitBehavior : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float range;
    [SerializeField] float maxDistance;

    Vector3 waypoint;
    // Start is called before the first frame update
    void Start()
    {
        SetNewDest();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint, speed * Time.deltaTime);
        Vector3 vectorToTarget = waypoint - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        const float angleSpeed = 10f;
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * angleSpeed);

        if (Vector2.Distance(transform.position, waypoint) < range)
            SetNewDest();
    }

    void SetNewDest()
    {
        waypoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}

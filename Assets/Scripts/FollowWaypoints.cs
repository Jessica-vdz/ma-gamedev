
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    
    public List <Transform> waypoints;
    private Transform target;
    public float speed;
    private int targetIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[targetIndex];
        
    }

    // Update is called once per frame
    void Update()
    {
        followWaypointint(target);
        GetNextTargetint(target);

    }

    private void checkArrived()
    {
        float distance = Vector3.Distance(transform.position , target.position);

        if (distance <= 0.1f)
        {
            targetIndex = (targetIndex + 1);
        }
    }
    private void followWaypointint(Transform waypoint)
    {
        Vector3 direction = (waypoint.position - transform.position); // transform.position pakt de positie van de npc in dit geval. 
        Vector3 newPosition = transform.position + (direction * (speed * Time.deltaTime));
        
        transform.position += transform.forward * speed;
        
    }

    private Transform GetNextTargetint(Transform followWaypoint)
    {
        if (targetIndex > 3)
        {
            targetIndex--;
            
        }
        else
        {
            targetIndex = 0;
        }
        return waypoints[targetIndex];
    }
}

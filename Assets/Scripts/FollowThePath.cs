using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowThePath : MonoBehaviour
{
    public GameObject trackCarb;
    public GameObject icecream;
    public GameObject cake;
    public GameObject canvas;
    
    public Transform[] waypoints;

    public float moveSpeed;

    private int waypointIndex = 0;

    private void Start()
    {
        // Set position of  as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        if (canvas.GetComponent<CanvasUIFunctions>().move)
            Move();
    }

    private void Move()
    {
        // If  didn't reach last waypoint it can move
        // If  reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length-1)
        {

            // Move  from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);
            // If  reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and  starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            

            
        }
    }
}
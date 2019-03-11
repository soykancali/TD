using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveEnemy : Singleton<MoveEnemy>
{ // Array of waypoints to walk from one to the next one
    [SerializeField]
    public Transform[] waypoints;
    // Walk speed that can be set in Inspector
    [SerializeField]
    public static float moveSpeed = 0.75f;
    public static int reach=0;
    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;
    public Slider monsterHealth;
    public float health;



    // Use this for initialization
    private void Start()
    {
        
        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        
        
        // Move Enemy
        Move();
    }

    // Method that actually make Enemy walk
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            if (waypointIndex == waypoints.Length)
            {
                reach = +1;
                
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("bullet"))
        {
            monsterHealth.value -= 0.2f;
            health -= 0.2f;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("bullet"))
        {
            monsterHealth.value -= 0.2f;
            health -= 0.2f;
            Destroy(other.gameObject);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
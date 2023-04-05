using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour
{
    public Transform[] waypoints;
    int cur = 0;

    public float speed = 0.3f;
    public float reachDistance = 0.1f;

    void Update()
    {
        // Waypoint reached, select next one
        if (Vector2.Distance(transform.position, waypoints[cur].position) < reachDistance)
        {
            cur = (cur + 1) % waypoints.Length;
        }
    }

    void FixedUpdate()
    {
        // Waypoint not reached yet? then move closer
        Vector2 p = Vector2.MoveTowards(transform.position,
                                        waypoints[cur].position,
                                        speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        // Animation
        Vector2 dir = waypoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "Pacman")
        Destroy(co.gameObject);
    }
}

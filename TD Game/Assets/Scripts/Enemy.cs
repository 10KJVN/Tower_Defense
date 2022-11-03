using UnityEngine;
using UnityEngine.AI;
using System.Collections;   

public class Enemy : MonoBehaviour
{
    public GameObject[] waypoints;
    public int Health;
    public int speed;
    private int currentWaypoint = 0;
    float WPradius = .1f;
    private Shop shopscript;
    WaveSpawner waveSpawner;

    public void Start()
    {
        shopscript = FindObjectOfType<Shop>();
    }

    void Update()
    {
        if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < WPradius)
        {
            if (currentWaypoint + 1 > waypoints.Length)
            {
                currentWaypoint = 0;
            }
            else
            {
                currentWaypoint++;
            }
            if (currentWaypoint == waypoints.Length - 1)
            {
                Destroy(gameObject);
            }
            if (currentWaypoint == 11)
            {
                Application.LoadLevel(5);
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, speed * Time.deltaTime);

    }

    public void TakeDamage()
    {

        if (Health == 0)
        {
            shopscript.currency++;
            Destroy(gameObject);

        }
    }
}

//using UnityEngine;

/*public class Enemy : MonoBehaviour
{
    /*public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start ()
    {
        target = Waypoints.points[0];
    }

    void Update ()
    {
        Vector2 dir  = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }*/
//}

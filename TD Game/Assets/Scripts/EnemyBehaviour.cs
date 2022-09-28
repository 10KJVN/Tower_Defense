using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public GameObject[] Waypoints;  //Array, blokje en naam van array
    public float speed;             //Ze moeten bewegen met bepaalde snelheid
    public float gap;               //float want het zijn comma getallen, int is hele getallen
    private int CurrentWaypoint;    //Floats = Floating Point Values.
    public int health;

    void Start()
    {
        CurrentWaypoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Waypoints[CurrentWaypoint].transform.position) < gap)
        {
            if(CurrentWaypoint + 1 < Waypoints.Length)
            {
                CurrentWaypoint ++;
            }
            else
            {
                CurrentWaypoint = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[CurrentWaypoint].transform.position, speed * Time.deltaTime);
    }

    public void TakeDamage(int someDamage)
    {
        health -= someDamage;
    }

}

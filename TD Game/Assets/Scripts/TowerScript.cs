using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    public GameObject Emitter;
    public float timer;
    public float speed;
    public float detectionRadius;
    /* Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;   
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            LookAt(); 
            Shoot(); //Referentie naar Schiet functie
            Emitter(); //Het punt of object waar de kogels uitkomen.

        }
    }

    /*private void GetClosestEnemy()
    {
        float distance = float.PositiveInfinity;
        foreach (var obj in Physics,OverlapSphere(transform.position, detectionRadius))
        {
          float 
        }
    }*/
}

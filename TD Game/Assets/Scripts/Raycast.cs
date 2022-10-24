using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float distance = 10f;
    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
       Camera cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
        hit = Physics2D.Raycast(transform.position, transform.right, distance);
        if(hit.collider != null)
        {
            Debug.DrawRay(transform.position, hit.point, Color.yellow);
            Debug.Log("Did Hit");  
        }
        else
        {
            Debug.DrawRay(transform.position, transform.position + transform.right * distance, Color.black);
            Debug.Log("Did not hit");
        }
         
        
    }
}

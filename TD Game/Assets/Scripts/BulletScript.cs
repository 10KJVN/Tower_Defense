using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public GameObject target;
    public float speed;
    public float time;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(target)
        {
            //transform.position = Vector2.MoveTowards.(transform);
        }
      else
        {
            transform.position += speed * Time.deltaTime * transform.forward;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyBehaviour>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

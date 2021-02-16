using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float jumpForce;
    public float speed;
    
    public Rigidbody2D rb;
    private Transform target;
    public SpriteRenderer spriteRenderer;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {

        

        float dist = Vector3.Distance(transform.position, target.transform.position);
        if(dist < 10)
        {
                 transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);      
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("triggerJump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
    
    }







}

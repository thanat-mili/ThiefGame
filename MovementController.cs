using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject elevatorTargetUp;
    public GameObject elevatorTargetDown;   
    public float moveSpeed = 1.0f;
    public Rigidbody rb;
    bool isCollidingUp;
    bool isCollidingDown;   
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    void OnTriggerStay(Collider collision)
    {
        if (collision.transform.tag == "UpElevator")
        {
            isCollidingUp = true;
            //collision.transform.gameObject.SetActive(false);

        }

        else if (collision.transform.tag == "DownElevator")
        {
            isCollidingDown = true;
            //collision.transform.gameObject.SetActive(false);

        }
        else
        {
            isCollidingUp = false;
            isCollidingDown=false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        //OnCollisionEnter();
        //Debug.Log("collide");
        if (isCollidingUp == true)
        {
            Debug.Log("collideUp");
            transform.position = Vector3.MoveTowards(transform.position, elevatorTargetUp.transform.position, moveSpeed * Time.deltaTime);
            rb.AddForce(0, 1.0f, 1.0f);
        }

        else if (isCollidingDown == true)
        {
            Debug.Log("collideDown");
            transform.position = Vector3.MoveTowards(transform.position, elevatorTargetDown.transform.position, moveSpeed * Time.deltaTime);
            rb.AddForce(0, -1.0f, -1.0f);
        }
    }
}

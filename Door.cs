using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    /*public GameObject openText;

    public AudioSource doorSound;*/


    public bool inReach;

    RaycastHit hit;



    public Transform PlayerCamera;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 5;

    private bool opened = false;

    void Start()
    {
        //inReach = false;
    }

    /*void OnTriggerEnter(Collider other)
    {
        inReach = true;
        openText.SetActive(true);

        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        inReach = false;
        openText.SetActive(false);

        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }*/





    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            Pressed();
            //Delete if you dont want Text in the Console saying that You Press F.
            Debug.Log("You Press F");
        }


        /*if (Physics.Raycast (transform.position, directionRay, out collisionRay, distanceRay) ) 
    {     
        if (collisionRay.collider.gameObject.tag == "Desired GameObject Tag" )
        {  
        scriptCommunication = destinationTransform.gameObject.GetComponent <Desired Script> ();
        scriptCommunication.designatedboolean = true; 
        }
    }*/






        /*if ((Physics.Raycast(transform.position, transform.forward, out hit)) && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("askdjapskn");
            DoorOpens();
        }

        else
        {
            DoorCloses();
        }*/




    }



    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit doorhit;

        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out doorhit, MaxDistance))
        {

            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (doorhit.transform.tag == "Door")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = doorhit.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                opened = !opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("Opened", !opened);
            }
        }
    }


    /*public void DoorOpens()
    {
       //Debug.Log("It Opens");
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        //doorSound.Play();

    }

    public void DoorCloses()
    {
        //Debug.Log("It Closes");
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }*/

}

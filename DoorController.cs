using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    private Animator doorAnim;
    private bool doorOpen = false;
    /*public GameObject openText;

    public AudioSource doorSound;*/


    //public bool inReach;

    //RaycastHit hit;

    public AudioSource doorOpenAudio;
    public AudioSource doorCloseAudio;

    /*public Transform PlayerCamera;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 5;
*/
    private bool opened = false;

    private void Awake()
    {
        doorAnim = GetComponent<Animator>();    
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play("DoorOpen", 0, 0.0f);
            doorOpenAudio.Play();
            doorOpen = true;
            //doorOpenAudio.time = 0.00f;
            
            //doorOpenAudio.SetScheduledEndTime(AudioSettings.dspTime + (0.00f - 1.00f));
        }
        else
        {
            doorAnim.Play("DoorClose", 0, 0.0f);
            doorCloseAudio.Play();
            doorOpen = false;
            //doorOpenAudio.time = 0.90f;
            
            //doorOpenAudio.SetScheduledEndTime(AudioSettings.dspTime + (0.90f - 2.00f));
        }
    }


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

        /*if (Input.GetKeyDown(KeyCode.F))
        {
            Pressed();
            //Delete if you dont want Text in the Console saying that You Press F.
            Debug.Log("You Press F");
        }*/


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



    /*void Pressed()
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
    }*/


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

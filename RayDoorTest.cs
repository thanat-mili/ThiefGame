using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RayDoorTest : MonoBehaviour
{
    DoorController raycastedObj;

    // Start is called before the first frame update
    Ray ray;
    public float distance = 10.0f;
    RaycastHit hit;
    public string focusTag = "Door";
    public Text displayText;
    public Text scoreText;
    int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //string stringScore = Score.ToString();
        scoreText.text = "Score :" + Score;
        displayText.gameObject.SetActive(false);
        ray = new Ray(transform.position, transform.forward);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        ray.origin = transform.position;
        ray.direction = transform.forward;

        //scoreText.text = "Score: " + Score;

        if (Physics.Raycast(ray.origin, fwd * distance, out hit, distance))
        {
            Debug.DrawRay(ray.origin, fwd * distance, Color.red);
            Debug.Log("Laser Hit: " + hit.collider.gameObject.name + ", Tag: " + hit.collider.tag);

            if (hit.collider.tag == focusTag)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Please press 'E'";
                raycastedObj = hit.collider.gameObject.GetComponent<DoorController>();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    raycastedObj.PlayAnimation();
                    //Physics.IgnoreLayerCollision(1,10);
                    //hit.collider.gameObject.SetActive(false);
                    //Score++;
                    //string stringScore = Score.ToString();
                    scoreText.text = "Score: " + Score;
                }
            }

            else
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Please find a green ball";
            }

        }

        else
        {
            displayText.gameObject.SetActive(false);
            Debug.DrawRay(ray.origin, fwd * distance, Color.green);
        }


    }
}

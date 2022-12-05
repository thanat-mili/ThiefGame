using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;


public class RayCasterController : MonoBehaviour
{

    public AudioSource stealAudio;

    DoorController raycastedObj;
    //ElevatorController ElevatorController;

    // Start is called before the first frame update
    Ray ray;
    public float distance = 1.0f;
    RaycastHit hit;
    public float rayDistance = 1.0f;
    public string focusTagDoor = "Door";
    //public string focusTagDoorL = "DoorL";
    public string focusTag1 = "Restaurant";
    public string focusTag2 = "Salon";
    public string focusTag3 = "TechCafe";
    public string focusTag4 = "Style";
    public string focusTag5 = "MarketCafe";
    public string focusTag6 = "MegaSports";
    public string focusTag7 = "Supermarket";
    public string focusTag8 = "Clothing";
    public string focusTag9 = "Music";
    public string focusTag10 = "TechZone";
    public string focusTag11 = "Gym";
    public string focusTag12 = "ArcadeZone";
    public Text displayText;
    public Text scoreText;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;
    //int Score = 0;

    public Door boolObj;


    int inventory1 = 0;
    int inventory2 = 0;
    int randomNumber1;
    int randomNumber2;
    string item1 = "item";
    string item2 = "item";
    string tag1 = "";
    string tag2 = "";
    int score1 = 0;
    int score2 = 0;
    //RaycastHit hit;




    // Start is called before the first frame update
    void Start()
    {
        //string stringScore = Score.ToString();
        //scoreText.text = "Score :" + Score;
        displayText.gameObject.SetActive(false);
        ray = new Ray(transform.position, transform.forward);


        var random = new System.Random();
        var list = new List<string> { "Restaurant", "Salon", "TechCafe", "Style", "MarketCafe", "MegaSports", "Music", "Clothing", "TechZone", "Gym" };
        //int index = random.Next(list.Count);

        int index1 = random.Next(list.Count);
        int index2 = random.Next(list.Count);
        randomNumber1 = random.Next(3, 6);
        randomNumber2 = random.Next(3, 6);

        while (index1 == index2)
        {
            index2 = random.Next(list.Count);
        }

        if (randomNumber1 > 1)
        {
            item1 = "items";
        }

        if (randomNumber2 > 1)
        {
            item2 = "items";
        }
        /*if (index1 == index2)
        {
            index2 = random.Next(list.Count);
        }*/
        tag1 = list[index1];
        tag2 = list[index2];

        /*scoreText.text = "Steal " + randomNumber1 + " " + item1 + " from " + list[index1];
        scoreText2.text = "Steal " + randomNumber2 + " " + item2 + " from " + list[index2];*/

        scoreText.text = "Steal " + randomNumber1 + " " + item1 + " from " + tag1;
        scoreText2.text = "Steal " + randomNumber2 + " " + item2 + " from " + tag2;

        Debug.Log("Steal " + randomNumber1 + " " + item1 + " from " + list[index1]);
        Debug.Log("Steal " + randomNumber2 + " " + item2 + " from " + list[index2]);
        /*Debug.Log(tag1);
        Debug.Log(tag2);*/

    }
    // Update is called once per frame
    void Update()
    {

        if (score1 >= randomNumber1 && score2 >= randomNumber2)
        {
            SceneManager.LoadScene(0);
        }

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        ray.origin = transform.position;
        ray.direction = transform.forward;

        //scoreText.text = "Score: " + Score;
        

        /*Debug.Log("Steal " + randomNumber1 + " " + item1 + " from " + tag1);
        Debug.Log("Steal " + randomNumber2 + " " + item2 + " from " + tag2);*/
        if (Physics.Raycast(ray.origin, fwd * distance, out hit, rayDistance))
        {
            Debug.DrawRay(ray.origin, fwd * distance, Color.red);
            //Debug.Log("Laser Hit: " + hit.collider.gameObject.name + ", Tag: " + hit.collider.tag);

            if (hit.collider.tag == focusTag1)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag2)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag3)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag4)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag5)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag6)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag7)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag8)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag9)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag10)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag11)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTag12)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to pick up";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    
                    hit.collider.gameObject.SetActive(false);
                    stealAudio.Play();
                    if (hit.collider.tag == tag1)
                    {
                        score1++;
                    }
                    if (hit.collider.tag == tag2)
                    {
                        score2++;
                    }
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTagDoor)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to open/close";
                raycastedObj = hit.collider.gameObject.GetComponent<DoorController>();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    raycastedObj.PlayAnimation();

                    /*GameObject DoorR = GameObject.FindGameObjectWithTag("DoorR");
                    boolObj = DoorR.GetComponent<Door>();
                    boolObj.inReach = true;*/
                    //hit.collider.gameObject.SetActive(false);

                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            /*else if (hit.collider.tag == focusTagDoorL)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to open/close";

                if (Input.GetKeyDown(KeyCode.E))
                {

                    GameObject DoorL = GameObject.FindGameObjectWithTag("DoorL");
                    boolObj = DoorL.GetComponent<Door>();
                    boolObj.inReach = true;
                    //hit.collider.gameObject.SetActive(false);
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }*/


            /*else if (hit.collider.tag == focusTagDoorR)
            {
                Animation = hit.transform.GetComponentInParent<T>
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to open/close";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameObject DoorR = GameObject.FindGameObjectWithTag("DoorR");
                    boolObj = DoorR.GetComponent<Door>();
                    boolObj.inReach = true;
                    //hit.collider.gameObject.SetActive(false);

                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }

            else if (hit.collider.tag == focusTagDoorL)
            {
                displayText.gameObject.SetActive(true);
                displayText.text = "Press 'E' to open/close";

                if (Input.GetKeyDown(KeyCode.E))
                {

                    GameObject DoorL = GameObject.FindGameObjectWithTag("DoorL");
                    boolObj = DoorL.GetComponent<Door>();
                    boolObj.inReach = true;
                    //hit.collider.gameObject.SetActive(false);
                    //Score++;
                    //string stringScore = Score.ToString();
                    //scoreText.text = "Score: " + Score;
                }
            }*/


            else
            {
                /*displayText.gameObject.SetActive(true);
                displayText.text = "Please find a green ball";*/
            }


        }

        else
        {
            displayText.gameObject.SetActive(false);
            Debug.DrawRay(ray.origin, fwd * distance, Color.green);
        }
        /*scoreText.text = "Steal " + randomNumber1 + " " + item1 + " from " + tag1;
        scoreText2.text = "Steal " + randomNumber2 + " " + item2 + " from " + tag2;*/
        scoreText3.text = "Total items stolen: " + score1;
        scoreText4.text = "Total items stolen: " + score2;
        /*Debug.Log(score1 + " and " + score2);
        Debug.Log(randomNumber1 + " and " + randomNumber2);*/

    }
    /*void RandomObj()
    {
        var random = new System.Random();
        var list = new List<string> { "Restaurant", "Salon", "TechCafe", "Style", "MarketCafe", "MegaSports", "Music", "Clothing", "TechZone", "Gym" };
        //int index = random.Next(list.Count);

        int index1 = random.Next(list.Count);
        int index2 = random.Next(list.Count);
        randomNumber1 = random.Next(1, 5);
        randomNumber2 = random.Next(1, 5);

        while (index1 == index2)
        {
            index2 = random.Next(list.Count);
        }

        if (randomNumber1 > 1)
        {
            item1 = "items";
        }

        if (randomNumber2 > 1)
        {
            item2 = "items";
        }
        *//*if (index1 == index2)
        {
            index2 = random.Next(list.Count);
        }*//*
        tag1 = list[index1];
        tag2 = list[index2];
        Debug.Log("Steal " + randomNumber1 + " " + item1 + " from " + list[index1]);
        Debug.Log("Steal " + randomNumber2 + " " + item2 + " from " + list[index2]);
    }*/
   
}

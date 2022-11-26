using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectiveCondition : MonoBehaviour
{
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
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
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

            if(randomNumber1 > 1)
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
            Debug.Log("Steal " + randomNumber1 +" "+ item1 + " from " + list[index1]);
            Debug.Log("Steal " + randomNumber2 +" "+ item2 + " from " + list[index2]);

            /*for (int i = 0; i < 2; i++)
            {
                
                int index = random.Next(list.Count);
                randomNumber = random.Next(2,5);
                if(index == index)
                 {
                     index = random.Next(list.Count);
                 }
                Debug.Log("Steal " + randomNumber + " items from " + list[index]);
               
            }*/
        }
    }
    // Update is called once per frame
    void Update()
    {
        

        if ((Physics.Raycast(transform.position, transform.forward, out hit)) && Input.GetKeyDown(KeyCode.E) && hit.collider.tag == tag1)
        {
            score1++;
        }
        else if ((Physics.Raycast(transform.position, transform.forward, out hit)) && Input.GetKeyDown(KeyCode.E) && hit.collider.tag == tag2)
        {
            score2++;
        }

        Debug.Log(score1 + " and " + score2);

        if (inventory1 == randomNumber1 && inventory2 == randomNumber2)
        {
            //change scene
        }
    }
}

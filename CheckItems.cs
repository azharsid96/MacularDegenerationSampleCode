using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckItems : MonoBehaviour
{
    //Get this list in CheckOut script at the end and tally with the shopping list prefabs
    //Change this to private after testing and debugging
    private List<string> triggerList;
    private bool isColliding = true;
    void Start()
    {
        triggerList = new List<string>();    
    }
    void OnTriggerEnter(Collider item)
    {
        if (item.tag != "Items")
        {
            if(item.tag == "Counter")
            {
                if (!isColliding)
                {
                    Scene scene = SceneManager.GetActiveScene();
                    SceneManager.LoadScene("EndScene");
                }
            }
            return;
        }

        

        //If the objects are not the hands of the player
        if (item.transform.parent.tag != "PlayerController")
        {
            //if the object is not already in the list
            if (!triggerList.Contains(item.name))
            {
                //add the object to the list
                triggerList.Add(item.name);
            }
        }
    }

    void OnTriggerExit(Collider item)
    {
        //if the object is in the list
        if (triggerList.Contains(item.name))
        {
            //remove it from the list
            triggerList.Remove(item.name);
        }

        if (item.tag == "Counter")
        {
            if (isColliding)
            {
                isColliding = false;
            }
        }


    }

    public List<string> GetBasketItems() {
        return triggerList;
    }
}

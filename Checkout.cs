using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkout : MonoBehaviour
{
    private CheckItems check;
    public ShoppingListGenerator listGenerator;
    public static bool finalResult;
    public static List<bool> results;
    //public GameObject screenText;

    void Start()
    {
        
        //a little manual effort but saves a lot of computations
        check = GameObject.FindGameObjectWithTag("Basket").transform.GetChild(5).GetComponent<CheckItems>();

        results = new List<bool>();

    }
    void OnTriggerEnter(Collider other)
    {   
        //Get the item collider list
        List<string> basketItems = check.GetBasketItems();

        for(int i = 0; i < basketItems.Count; i++)
        {
            basketItems[i] = basketItems[i].Split(' ')[0];
        }
        if (listGenerator.checkoutList != null)
        {
            //Print them
            foreach (string item in listGenerator.checkoutList)
            {
                if (basketItems.Contains(item))
                {
                    results.Add(true);
                    Debug.Log("Correct Item picked: " + item);

                }
                else
                {
                    results.Add(false);
                }
                //Debug.Log("Item name: " + item);
            }

            if (!results.Contains(false))
            {
                finalResult = true;
            }
            else
            {
                finalResult = false;
            }
        }
        else
        {
            return;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingListGenerator : MonoBehaviour
{
    public GameObject[] items;
    public List<string> shoppingList;
    public List<string> checkoutList;
    public GameObject shelf;
    public GameObject freezer;
    public List<GameObject> listOfItems;

    string[] enumType =
    {
        "CerealBox",
        "Can",
        "Chip",
        "Milk"
    };

    string[] enumCereal =
    {
        "Kellogg's Corn Flakes",
        "Cheerios",
        "Kellogg's Rice Krispies",
        "Kellogg's Mini Wheats",
        "Kellogg's All-Bran",
        "Kellogg's Crispix",
        "Kellogg's Frosted Mini Wheats"
    };

    string[] enumCan =
    {
        "Coke",
        "Coke Zero",
        "Diet Coke",
        "Mtn Dew",
        "Pepsi",
        "Sprite"
    };

    string[] enumMilk =
    {
        "Fat Free Milk",
        "1% Milk",
        "2% Milk",
        "Whole Milk"
    };

    string[] enumChips =
    {
        "Ray's Classic",
        "Ray's Flamin' Hot",
        "Ray's Barbecue",
        "Ray's Salt & Vinegar"
    };

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < shelf.transform.childCount; i++)
        {
            Shelf shelfType = shelf.transform.GetChild(i).gameObject.GetComponent<Shelf>();
            if (shelfType.stockType == Shelf.StockType.Cereal)
            {
                foreach(GameObject item in shelfType.stock)
                {
                    if(!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
            else if (shelfType.stockType == Shelf.StockType.Cans)
            {
                foreach (GameObject item in shelfType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
            else if (shelfType.stockType == Shelf.StockType.Milk)
            {
                foreach (GameObject item in shelfType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
            else if (shelfType.stockType == Shelf.StockType.Chips)
            {
                foreach (GameObject item in shelfType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
        }

        for (int i = 0; i < freezer.transform.childCount; i++)
        {
            Shelf freezerType = freezer.transform.GetChild(i).gameObject.GetComponent<Shelf>();
            if (freezerType.stockType == Shelf.StockType.Cereal)
            {
                foreach (GameObject item in freezerType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
            else if (freezerType.stockType == Shelf.StockType.Cans)
            {
                foreach (GameObject item in freezerType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
            else if (freezerType.stockType == Shelf.StockType.Milk)
            {
                foreach (GameObject item in freezerType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
            else if (freezerType.stockType == Shelf.StockType.Chips)
            {
                foreach (GameObject item in freezerType.stock)
                {
                    if (!listOfItems.Contains(item))
                    {
                        listOfItems.Add(item);
                    }
                }
            }
        }

            ListGenerator();
    }

    public void ListGenerator()
    {

        shoppingList = new List<string>();
        //add 4 random items into shoppingList with their generic type name
        for (int i = 0; i < 1; i++)
        {
            //gte a random item name from the items array
            string temp = (listOfItems[Random.Range(0, listOfItems.Count - 1)]).name;
            while (shoppingList.Contains(temp))
            {
                //makes sure the same item does not appear again in the shopping list
                temp = (listOfItems[Random.Range(0, listOfItems.Count - 1)]).name;
            }
            shoppingList.Add(temp);
        }

        checkoutList = new List<string>();

        for (int i = 0; i < shoppingList.Count; i++)
        {
            checkoutList.Add(shoppingList[i]);
        }

        //goes through the shopping list and updates the name to be the name shown on the list itself
        for (int i = 0; i < shoppingList.Count; i++)
        {
            //if item is a cereal box
            if (shoppingList[i].Split('_')[0].CompareTo(enumType[0]) == 0)
            {
                //item is CerealBox_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumCereal[0];
                   
                }
                //item is CerealBox_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumCereal[1];
                  
                }
                //item is CerealBox_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumCereal[2];
                    
                }
                //item is CerealBox_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumCereal[3];
                   
                }
                //item is CerealBox_5
                else if (shoppingList[i].Split('_')[1].CompareTo("5") == 0)
                {
                    shoppingList[i] = enumCereal[4];
                   
                }
                //item is CerealBox_6
                else if (shoppingList[i].Split('_')[1].CompareTo("6") == 0)
                {
                    shoppingList[i] = enumCereal[5];
                    
                }
                //item is CerealBox_7
                else if (shoppingList[i].Split('_')[1].CompareTo("7") == 0)
                {
                    shoppingList[i] = enumCereal[6];
                    
                }
            }
            //if item is a can
            else if (shoppingList[i].Split('_')[0].CompareTo(enumType[1]) == 0)
            {
                //item is Can_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumCan[0];
                }
                //item is Can_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumCan[1];
                }
                //item is Can_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumCan[2];
                }
                //item is Can_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumCan[3];
                }
                //item is Can_5
                else if (shoppingList[i].Split('_')[1].CompareTo("5") == 0)
                {
                    shoppingList[i] = enumCan[4];
                }
                //item is Can_6
                else if (shoppingList[i].Split('_')[1].CompareTo("6") == 0)
                {
                    shoppingList[i] = enumCan[5];
                }

            }
            //if item is chips
            else if (shoppingList[i].Split('_')[0].CompareTo(enumType[2]) == 0)
            {
                //item is Chip_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumChips[0];
                }
                //item is Chip_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumChips[1];
                }
                //item is Chip_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumChips[2];
                }
                //item is Chip_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumChips[3];
                }
            }
            //if item is milk
            else if (shoppingList[i].Split('_')[0].CompareTo(enumType[3]) == 0)
            {
                //item is Milk_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumMilk[0];
                }
                //item is Milk_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumMilk[1];
                }
                //item is Milk_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumMilk[2];
                }
                //item is Milk_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumMilk[3];
                }
            }
        }

        //print the shopping list onto the gameObject itself
        for(int i = 0; i < shoppingList.Count; i++)
        {
            gameObject.GetComponent<TextMesh>().text += (i+1).ToString() + "." + " " + shoppingList[i] + "\n";
        }


    }
}

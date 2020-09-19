using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRow : MonoBehaviour
{
    public bool autoUpdate;
    private List<Vector3> startPositions;
    private List<Vector3> endPositions;
    private GameObject[] Shelves;
    private Warehouse wareHouse;
    
    public void GenerateItems() {

        startPositions = new List<Vector3>();
        endPositions = new List<Vector3>();
        Shelves = GameObject.FindGameObjectsWithTag("Shelf");
        wareHouse = gameObject.GetComponentInChildren<Warehouse>();

        foreach (GameObject shelf in Shelves)
        {
            //store the startPositions and endPositions in a list for later ease of calculations 
            int numOfRows = shelf.transform.GetChild(1).childCount;
            
            //Store startPositions and endPositions for the current shelf
            for (int i = 0; i < numOfRows; ++i)
            {
                //Debug.Log()
                startPositions.Add(shelf.transform.GetChild(1).GetChild(i).transform.position);
                endPositions.Add(shelf.transform.GetChild(2).GetChild(i).transform.position);

            }

            //Set the stock for that particular shelf
            Shelf shelfComponent = shelf.GetComponent<Shelf>();

           //Get random stock from warehouse to stock

            if (shelfComponent.stockType == Shelf.StockType.Cereal)
            {
                shelfComponent.stock = wareHouse.GetRandomCereals(numOfRows);
            }
            else if (shelfComponent.stockType == Shelf.StockType.Milk)
            {
                shelfComponent.stock = wareHouse.GetRandomMilk(numOfRows);
            }
            else if (shelfComponent.stockType == Shelf.StockType.Cans)
            {
                shelfComponent.stock = wareHouse.GetRandomCans(numOfRows);
            }
            else if (shelfComponent.stockType == Shelf.StockType.Chips)
            {
                shelfComponent.stock = wareHouse.GetRandomChips(numOfRows);
            }

            //Find parent items GameObject
            GameObject parent = shelf.transform.Find("Items").gameObject;

            //Populate the Shelf for each row in the shelf
            for (int i = 0; i < numOfRows; ++i)
            {
                PopulateShelf(i, shelfComponent ,parent);
            }

            //Clear all lists before adding again
            startPositions.Clear();
            endPositions.Clear();

        }

    }

    public void DestroyItems() {

        GameObject[] items = GameObject.FindGameObjectsWithTag("Items");
        foreach (GameObject item in items) {
            DestroyImmediate(item);
        }
    }

    private void PopulateShelf(int rowNumber, Shelf shelf, GameObject parent)
    {
        float offset = 0;
        for (int i = 0; i < shelf.maxNumber; ++i)
        {
            //Get the new position of object to be created by shifting offset along the the row vector
            Vector3 newPos = startPositions[rowNumber] + (endPositions[rowNumber] - startPositions[rowNumber]).normalized * offset;
            
            //Create the actual object at that position
            GameObject temp = Instantiate(shelf.stock[rowNumber], newPos, parent.transform.rotation, parent.transform);

            //Rename the object for easy tokenization in checkout code
            temp.name = shelf.stock[rowNumber].name + " " + i;

            //Move the offsets accordingly
            offset += Random.Range(shelf.minGapBetweenObjects, shelf.maxGapBetweenObjects);
        }
    }

}


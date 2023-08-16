using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Stove stove;
    public string triggerName = "";
    public GameObject coffeePrefab;
    public GameObject LargeCoffeePrefab;
    public GameObject heldItem;
    public string heldItemName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            if (triggerName == "coffee")
            {
                heldItem = Instantiate(coffeePrefab, transform, false);
                heldItem.transform.localPosition = new Vector3(0, 2, 2);
                heldItemName = "CoffeeSlice";
            }

            if (triggerName == "LargeCoffee")
            {
                heldItem = Instantiate(coffeePrefab, transform, false);
                heldItem.transform.localPosition = new Vector3(0, 2, 2);
                heldItemName = "LargeCoffeeSlice";
            }

            if (triggerName == "Stove")
            {
                print("Hurry Up and Use The Fridgin Stove.");
                if (heldItemName == "CoffeeSlice")
                {
                    print("Ready to Burn Your Mouth From a Boiling Slice of Coffee?");
                    stove.BoilCoffeeSlice();
                    PlaceHeldItem();
                }
                else
                {
                    print("You have Nothing to Burn Yourself With!");
                    heldItem = Instantiate(coffeePrefab, transform, false);
                    heldItem.transform.localPosition = new Vector3(0, 2, 2);
                    heldItemName = "BoiledHotCoffee";
                    stove.CleanStove();
                }

                if (triggerName == "Stove")
                {
                    print("Hurry Up and Use The Fridgin Stove.");
                    if (heldItemName == "LargeCoffeeSlice")
                    {
                        print("Ready to Burn Your Mouth From a Boiling Slice of a Large Coffee?");
                        stove.BoilLargeCoffeeSlice();
                        PlaceHeldItem();
                    }
                    else
                    {
                        print("You have Nothing to Burn Yourself With!");
                        heldItem = Instantiate(coffeePrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 2, 2);
                        heldItemName = "LargeBoiledHotCoffee";
                        stove.CleanStove();
                    }

                }
                if (triggerName == "Recievers")
                {
                    print("I'm ready to make a dish!");
                    if (heldItemName == "BoiledHotCoffee")
                    {
                        PlaceHeldItem();
                        GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 1)").SetActive(true);
                        GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 1)/coffee").SetActive(true);
                        GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 1)/cup").SetActive(true);
                    }
                }
            }
        }

        void OnTriggerEnter(Collider other)
        {

            triggerName = other.name;
        }
        void OnTriggerExit(Collider collision)
        {
            triggerName = "";
        }

        void PlaceHeldItem()
        {
            Destroy(heldItem);
            heldItemName = "";
        }
    }
}

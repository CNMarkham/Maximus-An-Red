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

    void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }
    void OnTriggerExit(Collider collision)
    {
        triggerName = "";
    }

    // Update is called once per frame
    void Update()
    {
        void PlaceHeldItem()
        {
            Destroy(heldItem);
            heldItemName = "";
        }

        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "Recievers" && heldItemName == "BoiledHotCoffee")
            {

                PlaceHeldItem();

                GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 1)").SetActive(true);
                GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 1)/coffee").SetActive(true);
                GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 1)/cup").SetActive(true);
            }

            if (triggerName == "Recievers" && heldItemName == "LargeBoiledHotCoffee")
            {

                PlaceHeldItem();

                GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 2)").SetActive(true);
                GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 2)/coffee1").SetActive(true);
                GameObject.Find("Recievers/Two Coffees/Two Coffees(Part 2)/cup1").SetActive(true);
            }

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
                    heldItem = Instantiate(coffeePrefab, transform, false);
                    heldItem.transform.localPosition = new Vector3(0, 2, 2);
                    Invoke("stove.CompleteCooking", 6f);
                    heldItemName = "BoiledHotCoffee";
                    stove.CleanStove();
                }
                if (heldItemName == "LargeCoffeeSlice")
                {
                    print("Ready to Burn Your Mouth From a Boiling Slice of a Large Coffee?");
                    stove.BoilLargeCoffeeSlice();
                    PlaceHeldItem();
                    heldItem = Instantiate(coffeePrefab, transform, false);
                    heldItem.transform.localPosition = new Vector3(0, 2, 2);
                    Invoke("stove.CompleteCooking", 6f);
                    heldItemName = "LargeBoiledHotCoffee";
                    stove.CleanStoveLarge();
                }
            }
        }
    }
}

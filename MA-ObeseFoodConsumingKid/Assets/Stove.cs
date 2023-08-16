using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    public GameObject CoffeeSlice;
    public GameObject LargeCoffeeSlice;
    public string cookedFood = "";
    // Start is called before the first frame update
    void Start()
    {
        CoffeeSlice.SetActive(false);
        LargeCoffeeSlice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoilCoffeeSlice()
    {
        CoffeeSlice.SetActive(true);
        cookedFood = "CoffeeSlice";
    }

    public void BoilLargeCoffeeSlice()
    {
        LargeCoffeeSlice.SetActive(true);
        cookedFood = "LargeCoffeeSlice";
    }

    public void CleanStove()
    {
        CoffeeSlice.SetActive(false);
        cookedFood = "";
    }
}

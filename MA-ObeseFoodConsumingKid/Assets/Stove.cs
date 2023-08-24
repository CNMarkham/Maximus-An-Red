using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    public GameObject CoffeeSlice;
    public GameObject LargeCoffeeSlice;
    public string cookedFood = "";
    public bool isCooking = false;
    public ParticleSystem smoke;
    public ParticleSystem complete;
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
        isCooking = true;
        smoke.Play();
        CoffeeSlice.SetActive(true);
        cookedFood = "CoffeeSlice";
        Invoke("CompleteCooking", 8f);
    }

    public void BoilLargeCoffeeSlice()
    {
        isCooking = true;
        smoke.Play();
        LargeCoffeeSlice.SetActive(true);
        cookedFood = "LargeCoffeeSlice";
        Invoke("CompleteCooking", 8f);
    }

    public void CleanStove()
    {
        CoffeeSlice.SetActive(false);
        cookedFood = "";
        complete.Stop();
    }

    public void CleanStoveLarge()
    {
        LargeCoffeeSlice.SetActive(false);
        cookedFood = "";
        complete.Stop();
    }

    public void CompleteCooking()
    {
        isCooking = false;
        smoke.Stop();
        complete.Play();
    }
}

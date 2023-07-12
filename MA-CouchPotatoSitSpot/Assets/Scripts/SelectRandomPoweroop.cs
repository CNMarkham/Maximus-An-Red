using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPoweroop : MonoBehaviour
{
    public List<GameObject> poweroopList;
    public int randomNumberInList;
    public GameObject chosenPoweroop;
    public CodeyMove Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && randomNumberInList == 0)
        {
            Vector3 spawnLocation = transform.position + transform.forward * 15;
            GameObject Shell = Instantiate(poweroopList[0], spawnLocation, transform.rotation);
            GetComponent<CodeyMove>().Speed = -400;
            print("GET DEBUFFED LLLLLLL");
        }
        if (Input.GetKey(KeyCode.Space) == true && randomNumberInList == 1)
        {
            Vector3 spawnLocation = transform.position + transform.forward * 15;
            GameObject Shell = Instantiate(poweroopList[0], spawnLocation, transform.rotation);
            GetComponent<CodeyMove>().Speed = -400;
            print("GET DEBUFFED LLLLLLL");
        }
        //if (Input.GetKey(KeyCode.Space) == true && randomNumberInList == 1)
        //{
        //    Vector3 spawnLocation = GameObject.FindGameObjectWithTag("FinishBine").transform.position;
        //    GameObject Shell = Instantiate(poweroopList[1], spawnLocation, transform.rotation);
        //    GetComponent<CodeyMove>().Speed = -400;
        //    print("GET DEBUFFED LLLLLLL");
        //    Invoke("DisabklePlayerMovement", 7);
        //}
        if (Input.GetKey(KeyCode.Space) == true && randomNumberInList == 2)
        {
            Vector3 spawnLocation = GameObject.FindGameObjectWithTag("FinishBine").transform.position;
            GameObject Shell = Instantiate(poweroopList[1], spawnLocation, transform.rotation);
            GetComponent<CodeyMove>().Speed = -400;
            print("GET DEBUFFED LLLLLLL");
            Invoke("DisabklePlayerMovement", 7);
        }
    }

     void DisabklePlayerMovement()
    {
        GetComponent<CodeyMove>().Speed = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, poweroopList.Count);
            chosenPoweroop = poweroopList[randomNumberInList];
        }

    }
}

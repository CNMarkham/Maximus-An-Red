using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public Collectable collectable;
    public LivesManager livesManager;
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;

    public Vector3 originalSlimePosition;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (livesManager.lives < 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
            
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
                );
            slimeTransform.position = originalSlimePosition - launchVector / 400;
            launchVector.Normalize();
        }
        if (Input.GetMouseButtonUp(0))
        {
            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchForce * launchVector, ForceMode.Impulse);
        }
    }
}
    


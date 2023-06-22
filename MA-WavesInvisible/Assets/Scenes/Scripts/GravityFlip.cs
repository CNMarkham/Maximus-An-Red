using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public GameObject Avatar;
    public Rigidbody2D avatarRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        avatarRigidbody.gravityScale *= -1;


        Vector3 newDirection = transform.localScale;
        newDirection.y *= -1;

        Avatar.transform.localScale = newDirection;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1;


            Vector3 newDirection = transform.localScale;
            newDirection.y *= -1;

            Avatar.transform.localScale = newDirection;
        }
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public Text collectableCounter;
    public Teleport Teleporter;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyCount2 = 5;
        throwableCounter = 0;
        Teleporter = FindObjectOfType<Teleport>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = transform.localScale.x * new Vector3(1, 0, 0);
        if (Input.GetButtonDown("Fire1") && throwableCounter > 0)
        {
            throwableCounter -= 1;
            collectableCounter.text = throwableCounter.ToString();
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        {
        if (other.gameObject.CompareTag("Collectable"))
            throwableCounter += 1;
            collectableCounter.text = throwableCounter.ToString();
            Teleporter.enemyCount -= 1;
            Destroy(other.gameObject);
        }
    }
}

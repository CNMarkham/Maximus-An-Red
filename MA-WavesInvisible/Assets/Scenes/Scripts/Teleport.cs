using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public int enemyCount;
    Throwable ObjectThrow;
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && enemyCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}


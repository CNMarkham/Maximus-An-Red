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
        //ObjectThrow
        //if(ObjectThrow.enemyCount2 == 4)
        //{
        //    enemyCount = 4;
        //}
        //if (ObjectThrow.enemyCount2 == 3)
        //{
        //    enemyCount = 3;
        //}
        //if (ObjectThrow.enemyCount2 == 2)
        //{
        //    enemyCount = 2;
        //}
        //if (ObjectThrow.enemyCount2 == 1)
        //{
        //    enemyCount = 1;
        //}
        //if (ObjectThrow.enemyCount2 == 0)
        //{
        //    enemyCount = 0;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && enemyCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}


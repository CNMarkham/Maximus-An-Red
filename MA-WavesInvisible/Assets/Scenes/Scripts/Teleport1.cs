using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport1 : MonoBehaviour
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
        if(enemyCount == 0)
        {
            Destroy(this);
        }
    }

    
}


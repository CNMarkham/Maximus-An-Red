using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public float distanceToMove;
    private Vector3 startingPosition;
    private Vector3 endingPosition;
    public float speed = 0.1f;
    public float direction = -1f;

    [Header("Scene to Load")]
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Invoke("LoadNextScene, 2f");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

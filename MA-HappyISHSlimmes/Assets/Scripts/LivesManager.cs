using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    [Header("Lives")]
    public LivesManager livesManager;

    public Rigidbody slimeRigidbody;

    public int lives;
    public GameObject[] hearts;
    // Start is called before the first frame update

    public void RemoveLife()
    {
        lives -= 1;
        hearts[lives].SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Invoke("RemoveLife", 1f);
            transform.position = new Vector3(1.0f, 1.0f, 1.0f);
            slimeRigidbody.isKinematic = true;

        }
    }


}

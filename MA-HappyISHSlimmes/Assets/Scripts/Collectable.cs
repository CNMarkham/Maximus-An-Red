using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public AnimationCurve curve;
    public float CollectableNumber;
    public Vector3 startpos;
    public Vector3 endpos;
    public float time;
    public float distanceToMove;

    public float speed = 0.1f;
    public float direction = -1f;

    [Header("Scene to Load")]
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        CollectableNumber = 0;
    }
    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            gameObject.SetActive(false);
            CollectableNumber += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(CollectableNumber >= 2)
        {
            Invoke("LoadNextScene", 2f);
        }
        time += Time.deltaTime;
        transform.position = Vector3.Lerp(startpos, endpos, curve.Evaluate(time));
    }
}

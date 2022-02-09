using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider thing)
    {
        if (thing.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.Instance.score += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}

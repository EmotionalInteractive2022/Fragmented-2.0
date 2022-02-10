using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collectable : MonoBehaviour { 

    public static int fragmentCount = 1; 

    // Start is called before the first frame update
    void OnTriggerEnter(Collider thing)
    {
        if (thing.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.Instance.score += 1;
            if (fragmentCount >= 1)
                SceneManager.LoadScene(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
          
    }
}


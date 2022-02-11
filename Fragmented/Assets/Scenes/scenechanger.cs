using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public void onCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}
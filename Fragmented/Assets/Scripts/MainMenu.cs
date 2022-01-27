
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayTheGame()
    {
        Debug.Log("I am working!");
        SceneManager.LoadScene(1);
    }


}
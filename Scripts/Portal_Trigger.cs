
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_Trigger : MonoBehaviour
{
    // public GameManager gameManager;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene("MainMap");
    }
}

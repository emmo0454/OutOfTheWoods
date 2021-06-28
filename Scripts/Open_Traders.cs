using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Traders : MonoBehaviour
{
    void OnTriggerEnter(){
      SceneManager.LoadScene("Traders_Menu");
    }
}

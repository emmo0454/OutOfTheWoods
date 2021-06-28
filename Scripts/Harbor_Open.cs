using UnityEngine;
using UnityEngine.SceneManagement;

public class Harbor_Open : MonoBehaviour
{
    void OnTriggerEnter(){
      SceneManager.LoadScene("Harbor_Menu");
    }
}

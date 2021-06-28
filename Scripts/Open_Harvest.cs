using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Harvest : MonoBehaviour
{
    void OnTriggerEnter(){
      SceneManager.LoadScene("Gardens_Menu");
    }
}

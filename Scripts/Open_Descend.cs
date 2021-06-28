using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_Descend : MonoBehaviour
{
    void OnTriggerEnter(){
      SceneManager.LoadScene("Mines_Menu");
    }
}

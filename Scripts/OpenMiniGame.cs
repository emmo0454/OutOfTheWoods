using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMiniGame : MonoBehaviour
{
    public string miniGame;
    public void LoadLevel(){
      SceneManager.LoadScene(miniGame);
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class navigation : MonoBehaviour
{
    public void Return(){
      SceneManager.LoadScene("MainMap");
    }
    public void Restart(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Menu(){
      SceneManager.LoadScene("Menu");
    }
    public void Quit(){
      SceneManager.LoadScene("Quit");
    }
    public void Descend(){
      SceneManager.LoadScene("Descend_MiniGame");
    }
    public void Balance(){
      SceneManager.LoadScene("Balance_MiniGame");
    }
    public void Harvest(){
      SceneManager.LoadScene("Harvest_MiniGame");
    }
    public void Haggle(){
      SceneManager.LoadScene("Haggle");
    }
    public void Pay_Fare(){
      SceneManager.LoadScene("Pay_Fare");
    }
}

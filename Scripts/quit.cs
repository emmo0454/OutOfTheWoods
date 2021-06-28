using UnityEngine;

public class quit : MonoBehaviour
{
    public void Exit(){
      Debug.Log("Quit");
      Application.Quit();
    }
}

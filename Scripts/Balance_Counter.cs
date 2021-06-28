using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Balance_Counter : MonoBehaviour
{
    public Game_Manager gameManager;
    public bool offBoard = false;
    public float coinsEarned;

    void OnCollisionEnter(Collision collision)
    {
      if(collision.collider.tag == "water"){
        offBoard = true;
        coinsEarned = Time.timeSinceLevelLoad;
        Game_Manager.coinCount = Game_Manager.coinCount + (float)(Math.Ceiling(coinsEarned/10));
        Debug.Log(Game_Manager.coinCount);
      }
    }
}

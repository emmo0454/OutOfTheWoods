using UnityEngine;

public class Coin_Collector : MonoBehaviour
{
    // public float coinCount;
    public Game_Manager gameManager;
    public float currentCoin;

    void OnCollisionEnter(Collision collision)
    {
      // DontDestroyOnLoad(Game_Manager.gameManager);
      if(collision.collider.tag == "Coins")
      {
        Destroy(collision.gameObject);
        currentCoin++;
        Game_Manager.coinCount = Game_Manager.coinCount+1;
        Debug.Log(Game_Manager.coinCount);
      }
    }
}

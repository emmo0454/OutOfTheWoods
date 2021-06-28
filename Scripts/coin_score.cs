using UnityEngine;
using System;
using UnityEngine.UI;

public class coin_score : MonoBehaviour
{
    public Game_Manager gameManager;
    public Coin_Collector coinCollect;
    public Text scoreText;

    void Update()
    {
          scoreText.text = Game_Manager.coinCount.ToString("0");
    }
}

using UnityEngine;
using System;
using UnityEngine.UI;

public class crop_score : MonoBehaviour
{
    public Game_Manager gameManager;
    public Text scoreText;

    void Update()
    {
          scoreText.text = Game_Manager.cropCount.ToString("0");
    }
}

using UnityEngine;
using System;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // public Balance_Counter balanceCount;
    public Text scoreText;

    void Update()
    {
          scoreText.text = (Math.Floor(Time.timeSinceLevelLoad/10)).ToString("0");
    }
}

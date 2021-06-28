using UnityEngine;
using UnityEngine.UI;

public class CoinChange : MonoBehaviour
{
    public Text Textfield;
    public Game_Manager gameManager;

    public void SetText(string text){
      Textfield.text = text;
      Game_Manager.coinCount = Game_Manager.coinCount - 10;
      Game_Manager.cropCount = Game_Manager.cropCount - 10;
    }
}

using UnityEngine;

public class Crop_Collector : MonoBehaviour
{
    public Game_Manager gameManager;

    void OnCollisionEnter(Collision collision)
    {
      if(collision.collider.tag == "Crops")
      {
        Destroy(collision.gameObject);
        Game_Manager.cropCount = Game_Manager.cropCount+1;
        Debug.Log(Game_Manager.cropCount);
      }
    }
}

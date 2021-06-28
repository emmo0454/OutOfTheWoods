using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {
      if(Input.GetKey("w")){
        rb.AddForce(0, 0, forwardForce*Time.deltaTime, ForceMode.VelocityChange);
      }
      if(Input.GetKey("s")){
        rb.AddForce(0, 0, -forwardForce*Time.deltaTime, ForceMode.VelocityChange);
      }
      if(Input.GetKey("d")){
        rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);

      }
      //steer left
      if(Input.GetKey("a")){
        rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);

      }

    }
}

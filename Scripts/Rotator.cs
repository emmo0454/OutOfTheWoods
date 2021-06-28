using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
          rotation = new Vector3(0f,1f,0f);
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(rotation);
    }
}

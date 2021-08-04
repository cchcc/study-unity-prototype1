using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private const float speed = 10.0f;
    private const float turnSpeed = 25f;
    private float horizontalInput = 0f;
    private float forwardInput = 0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("P2Horizontal");
        forwardInput = Input.GetAxis("P2Vertical");
        
        // Move the vehicle forward
        // transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

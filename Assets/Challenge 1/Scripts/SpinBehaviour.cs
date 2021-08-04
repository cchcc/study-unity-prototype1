using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 100 * 20 * Time.deltaTime);
    }
}

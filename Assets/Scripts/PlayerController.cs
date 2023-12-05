using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float rotationInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * rotationSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * rotationInput * speed);
        
    }
}

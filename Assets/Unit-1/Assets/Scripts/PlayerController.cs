using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15;
    private float turnSpeed = 50;
    private float horizontalInput;
    private float forwardInput ;

    // Update is called once per frame
    void Update()
    {
        // Hér er tekið inn frá spilara.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Bíllinn er færður áfram.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Bíllinn beygir
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kod_Tank_Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Kod_Tank_Input input;

    public float tankSpeed;
    public float tankRotationSpeed;
    public Transform Namlu;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<Kod_Tank_Input>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
        NamluHareketi();
    }

    void HandleMovement()
    {
        Vector3 wantedPosition = transform.position +
            (input.forwardInput*  transform.forward * tankSpeed * Time.deltaTime);
        rb.MovePosition(wantedPosition);

        Quaternion wantedRotation = transform.rotation *
            Quaternion.Euler(Vector3.up * 
            (input.rotationInput * tankRotationSpeed * Time.deltaTime));
        rb.MoveRotation(wantedRotation);


    }

    void NamluHareketi()
    {
        Vector3 istenenNamluYonu = input.hedefNoktasi - Namlu.position;
        istenenNamluYonu.y = 0;

        Namlu.rotation = Quaternion.LookRotation(istenenNamluYonu);



    }
}

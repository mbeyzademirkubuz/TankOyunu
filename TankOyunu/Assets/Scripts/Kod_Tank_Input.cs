using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kod_Tank_Input : MonoBehaviour
{
    public float forwardInput;
    public float rotationInput;

    public Camera kamera;
    public Vector3 hedefNoktasi;


    

    
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        //namlu hareketini al�r
        Ray screenRay = kamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(screenRay,out hit ))
        {
            hedefNoktasi = hit.point;
        }


        //y�nleri al�r
        forwardInput = Input.GetAxis("Vertical");
        rotationInput = Input.GetAxis("Horizontal");
    }
}

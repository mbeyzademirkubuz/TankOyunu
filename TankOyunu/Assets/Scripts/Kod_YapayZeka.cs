using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kod_YapayZeka : MonoBehaviour
{
    //hedef alma
    public Transform hedefNesne;
    public float mesafe;
    public Transform turretTransform;


    //atesleme
    public Transform mermi;
    public Transform namluUcu;
    public float mermiHizi;


    public float mermiZamanAraligi;


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector3.Distance(transform.position, hedefNesne.position) < mesafe);

        if (Vector3.Distance(transform.position, hedefNesne.position) < mesafe )
        {
            Debug.Log("Dusman menzile girdi.");
        }

        HandleTurret();
        
    }

    void HandleTurret()
    {
        Vector3 turretLookDir = hedefNesne.position - turretTransform.position;
        turretLookDir.y = 0;

        turretTransform.rotation = Quaternion.LookRotation(turretLookDir);

        if(Time.time > mermiZamanAraligi)
        {
            Atesle();

            mermiZamanAraligi = Time.time + 1f;
        }
    }

    void Atesle()
    {
        var olusturulanMermi = (GameObject)Instantiate(mermi.gameObject,
                                                        namluUcu.position,
                                                        namluUcu.rotation
                                                            );

        olusturulanMermi.GetComponent<Rigidbody>().AddForce(olusturulanMermi.transform.forward * mermiHizi,
                                                            ForceMode.Impulse);
    }
}

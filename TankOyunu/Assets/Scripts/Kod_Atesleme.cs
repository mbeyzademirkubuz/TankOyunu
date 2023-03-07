using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kod_Atesleme : MonoBehaviour
{
    public Transform mermi;
    public Transform namluUcu;
    public float mermiHizi;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            // 0 farenin sol týký anlamýna gelir.

            Atesle();

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

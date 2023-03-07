using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kod_Kamera_Takip : MonoBehaviour
{
    public Transform hedefNesne;
    public Vector3 mesafe;
    public float yumusakHiz;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        Vector3 istenenPoz = hedefNesne.position + mesafe;

        Vector3 yumusatýlmýsPoz = Vector3.Lerp(transform.position,
                                                istenenPoz, yumusakHiz);

        transform.position = yumusatýlmýsPoz;
    }
}

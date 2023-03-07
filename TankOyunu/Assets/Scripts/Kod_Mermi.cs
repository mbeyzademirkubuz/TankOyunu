using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kod_Mermi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("oyuncu"))
        {
            other.transform.GetComponent<Kod_Tank_Can>().canEksilt();


        }

        else if(other.transform.CompareTag("yapay"))
        {
            Destroy(other.gameObject);
        }

        Destroy(this.gameObject);
    }
}

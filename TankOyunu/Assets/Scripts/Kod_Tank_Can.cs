using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kod_Tank_Can : MonoBehaviour
{

    public GameObject buton_yenidenOyna;

    public int canSayisi;


    void Start()
    {
        
    }

    public void canEksilt()
    {
        canSayisi -= 1;

        if (canSayisi < 1)
        {
            buton_yenidenOyna.SetActive(true);

        }   
    }

    public void buton_YenidenOyna()
    {
        SceneManager.LoadScene(0);
        
    }

}

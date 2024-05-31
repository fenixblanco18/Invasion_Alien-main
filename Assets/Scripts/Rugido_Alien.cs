using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rugido_Alien : MonoBehaviour
{
    public float tiempoEspera = 0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Rugir",tiempoEspera,tiempoEspera);
    }
    void Rugir()
         {
            GetComponent<AudioSource>().Play();
         }
        
    // Update is called once per frame

}

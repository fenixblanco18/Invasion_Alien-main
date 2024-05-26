using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LuzParpadeante : MonoBehaviour
{
    public float intervalo = 1.0f; // Intervalo de parpadeo en segundos
    private Light miLuz;
    private float tiempoPasado = 0.0f;
    private bool encendida = true;

    void Start()
    {
        miLuz = GetComponent<Light>();
    }

    void Update()
    {
        tiempoPasado += Time.deltaTime;

        if (tiempoPasado >= intervalo)
        {
            tiempoPasado = 0.0f;
            encendida = !encendida;
            miLuz.enabled = encendida;
        }
    }
}


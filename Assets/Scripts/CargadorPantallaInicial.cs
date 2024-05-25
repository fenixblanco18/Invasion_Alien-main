using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargadorPantallaInicial : MonoBehaviour
{
    public float tiempoEspera;
    void Start()
    {
        Invoke("CargarEscenaPrincipal",tiempoEspera);
    }


    void CargarEscenaPrincipal()
    {
        SceneManager.LoadScene(1);
    }
}

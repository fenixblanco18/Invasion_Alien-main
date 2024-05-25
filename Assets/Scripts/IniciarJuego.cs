using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    // Start is called before the first frame updatepublic void IniciarJuego(){
    public void IniciarJuegos(){
        SceneManager.LoadScene(1);
    }
}

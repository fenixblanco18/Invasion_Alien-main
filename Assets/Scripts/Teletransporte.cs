using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider c){
        
        SceneManager.LoadScene(2);
        //SceneManager.LoadScene("ExteriorScene");
     }
}
    

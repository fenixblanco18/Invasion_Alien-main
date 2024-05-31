using System.Collections;
using System.Collections.Generic;
using SanBlasNPC;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemigoHealthManager : MonoBehaviour
{
    public Slider slider;
    public int salud=100;
    public void HacerPupa(int pupa){
        salud-=pupa;
        slider.value = salud;
        if (salud <= 0) 
        {
            GetComponent<Animator>().SetTrigger("Die");
            GetComponent<NPCSmartEnemy>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<AudioSource>().enabled = false; 
            //Destroy(gameObject, salud);
            Destroy(GetComponentInChildren<Canvas>().gameObject);
        }
   
    }



   


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePuertas : MonoBehaviour
{
    public string tagPlayer;
    public string tagEnemy = "SIN ETIQUETAR";
    public Animator animatorPuerta;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag(tagPlayer) || other.gameObject.CompareTag(tagEnemy))
        {
            animatorPuerta.enabled = true;
        }
    }
}

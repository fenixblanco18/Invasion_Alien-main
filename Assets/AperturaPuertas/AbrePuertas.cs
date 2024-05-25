using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePuertas : MonoBehaviour
{
    public string tagPlayer;
    public Animator animatorPuerta;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag!=null && other.gameObject.CompareTag(tagPlayer))
        {
            animatorPuerta.enabled = true;
        }
    }
}

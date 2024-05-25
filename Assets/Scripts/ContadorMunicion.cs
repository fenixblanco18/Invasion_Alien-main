using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMunicion : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="CajaCartuchos"){
            Destroy(c.gameObject);
            GetComponent<Arma>().municion+=8;
        }
    }
}

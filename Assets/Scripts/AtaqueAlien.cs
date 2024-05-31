using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueAlien : MonoBehaviour
{
    // Start is called before the first frame update
    public int GolpeGarra = 1;
    void OnTriggerEnter(Collider collision)
    {
    
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealthManager>().RecibirPupa(GolpeGarra);
        }

    }
}

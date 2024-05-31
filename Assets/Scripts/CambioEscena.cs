using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour

   {
    // Start is called before the first frame update
    void OnTriggerEnter(Collider c)
    {
        if (c.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
            //SceneManager.LoadScene("ExteriorScene");
        }

    }
}

  






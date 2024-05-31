using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider c)
    {
        if (c.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
            //SceneManager.LoadScene("ExteriorScene");
        }

    }
}


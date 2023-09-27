
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterScene2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Chargez la scène "scene1" lorsque le joueur entre dans la zone d'eau.
            SceneManager.LoadScene("Scene1");
        }
    }
}




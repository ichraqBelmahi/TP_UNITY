
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public static int catBotsRemaining;

    void Start()
    {
        catBotsRemaining = GameObject.FindGameObjectsWithTag("CatBot").Length;
    }
    public static void CatBotDestroyed()
    {
        catBotsRemaining--;

        if (catBotsRemaining <= 0)
        
            SceneManager.LoadScene("Scene2");
        }
    }


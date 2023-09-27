using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    TMP_Text timerText;

    void Start()
    {
        timerText = GameObject.Find("lblTime").GetComponent<TMP_Text>();
        StartCoroutine(TimerTick());
    }

    void Update()
    {
        
    }

    IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0) 
        {
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--; 
            timerText.text = "Time: " + GameVariables.currentTime.ToString();
        }

        SceneManager.LoadScene("Scene1");
    }
}

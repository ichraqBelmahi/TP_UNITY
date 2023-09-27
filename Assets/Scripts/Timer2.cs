using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("TIME").GetComponent<TMP_Text>();
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

        SceneManager.LoadScene("Scene2");
    }
}
using TMPro;
using UnityEngine;
public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    int nbCats = 0;
    private changeScene changeScene;
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        changeScene = FindObjectOfType<changeScene>();
    }
    void Update()
    {
    }
    public void AddHit()
    {
        nbCats++;
        headText.text = "BobHeads: " + nbCats;
        changeScene.CatBotDestroyed();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class normal_encount : MonoBehaviour
{
    public DialogueBassclass.TEXTS texts;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (overworldmove.moveget("+",0) >= 450&&a==false)
        {
            texts.flashs("normal_battle");
            a = true;
            overworldmove.moveget("=",0);
        }
    }
}

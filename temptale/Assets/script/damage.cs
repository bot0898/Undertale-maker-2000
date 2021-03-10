using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damage : MonoBehaviour
{
    public int attacktype;
    public float HP;
    public float MaxHP;
    public float damag;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueBassclass.TEXTS.HPchange(0,"+") <= DialogueBassclass.TEXTS.MHPget())
        {
            SceneManager.LoadScene ("GAMEOVER");
        }
        if (HP > MaxHP)
        {
            DialogueBassclass.TEXTS.HPchange(DialogueBassclass.TEXTS.MHPget(),"=");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (attacktype == 0 && other.gameObject.CompareTag("attack"))
        {
            DialogueBassclass.TEXTS.HPchange(damag*2,"-");
        }
    }
}

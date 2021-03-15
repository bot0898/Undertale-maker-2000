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
    public bool debug;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueBassclass.TEXTS.HPchange(0,"+") <=0&&debug==false)
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
            DialogueBassclass.TEXTS.HPchange(damag,"-");
        }
        if (attacktype == 0 && other.gameObject.CompareTag("orange")&&Input.GetAxisRaw("Horizontal")==0&&Input.GetAxisRaw("Vertical")==0)
        {
            DialogueBassclass.TEXTS.HPchange(damag,"-");
            Debug.Log(damag);
        }
        if (attacktype == 0 && other.gameObject.CompareTag("blue")&&Input.GetAxisRaw("Horizontal")==1&&Input.GetAxisRaw("Vertical")==1)
        {
            DialogueBassclass.TEXTS.HPchange(damag,"-");
            Debug.Log(damag);
        }
    }
}

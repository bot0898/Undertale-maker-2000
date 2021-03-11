using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int HP;
    public int XP;
    public int mercyturn;
    public Sprite[] b;
    public bool mercy;
    private SpriteRenderer rd;
    public GameObject d;
    public attackmaker Attackmaker;
    public float aa;
    public Color color1;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mercyturn == Attackmaker.turn)
        {
            mercy = true;
        }
        if (Attackmaker.ends == true&&mercy == true)
        {
            this.gameObject.GetComponent<Renderer>().material.color = color1;
        }
    }
    public void damage(int a)
    {
        HP -= a;
        if (a != 0)
        {
           rd.sprite = b[1];
        }
        StartCoroutine("timer");
        if (HP <= 0)
        { 
            DialogueBassclass.dialogs.winget("=",2);
            d.GetComponent<DialogueBassclass.dialogs>().youwin(XP); 
            gameObject.SetActive (false);
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(1f);
        rd.sprite = b[0];
    }
}

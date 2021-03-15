using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackmaker : MonoBehaviour
{
    public GameObject[] trggers = new GameObject[100];
    public GameObject[] others = new GameObject[100];
    public GameObject[] attacks = new GameObject[100];
    public GameObject[] d = new GameObject[40];
    public int turn;
    public int attackr;
    public bool myturn;
    public bool ends;
    public bool firstattack;
    public DialogueBassclass.texts Sanstextmap;
    public heartmove_remastered hearts;
    public bool n0rmal;
    // Start is called before the first frame update
    void Start()
    {
        if (firstattack == true)
        {
            myturn = false;
            if (Sanstextmap.c[turn] == false)
            {
            d[0].GetComponent<DialogueBassclass.texts>().text();
            hearts.c[6] = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("t")){
            this.gameObject.GetComponent<attackmaker>().startattack();
        }
        others[0].GetComponent<turn>().turns();
        others[1].GetComponent<turn>().turns();
    }
    public void startattack()
    {
        if (ends == false)
        {
            StartCoroutine(attack(turn));
        }
    }
    public void attackend()
    {
        myturn = true;
    }
    IEnumerator attack(int turns)
    {
        if (n0rmal == false)
        {
            if (ends == false)
            {
                if (turns ==  0)
                {
                    trggers[0] = Instantiate(attacks[0]) as GameObject; 
                    trggers[0].GetComponent<attackmove>().go();
                    yield return new WaitForSeconds(2f);
                    this.GetComponent<attackmaker>().attackend();
                }
                if (turns ==  1)
                {
                    trggers[0] = Instantiate(attacks[0]) as GameObject; 
                    trggers[0].GetComponent<attackmove>().go();
                    yield return new WaitForSeconds(2f);
                    this.GetComponent<attackmaker>().attackend();
                }
                if (turns ==  2)
                {
                    trggers[1] = Instantiate(attacks[0]) as GameObject; 
                    trggers[1].GetComponent<attackmove>().go();
                    yield return new WaitForSeconds(2f);
                    this.GetComponent<attackmaker>().attackend();
                }
            }
        }
        if (n0rmal == true)
        {
            if (ends == false)
            {
                attackr = Random.Range(1, 3);
                if (attackr ==  1)
                {
                    trggers[0] = Instantiate(attacks[0]) as GameObject; 
                    trggers[0].GetComponent<attackmove>().go();
                    yield return new WaitForSeconds(2f);
                    this.GetComponent<attackmaker>().attackend();
                }
                if (attackr ==  2)
                {
                    trggers[0] = Instantiate(attacks[0]) as GameObject; 
                    trggers[0].GetComponent<attackmove>().go();
                    yield return new WaitForSeconds(2f);
                    this.GetComponent<attackmaker>().attackend();
                }
                if (attackr ==  3)
                {
                    trggers[1] = Instantiate(attacks[0]) as GameObject; 
                    trggers[1].GetComponent<attackmove>().go();
                    yield return new WaitForSeconds(2f);
                    this.GetComponent<attackmaker>().attackend();
                }
            }
        }
        yield return null;
    }
    public void Text() 
    {
        if (ends == false)
        {
        myturn = false;
        if (Sanstextmap.c[turn] == true)
        {
            this.GetComponent<attackmaker>().startattack();
            hearts.c[6] = true;
        }else if (Sanstextmap.c[turn] == false)
        {
           d[0].GetComponent<DialogueBassclass.texts>().text();
           hearts.c[6] = true;
        }
        }
    }
    public void end()
    {
        ends = true;
    }
}

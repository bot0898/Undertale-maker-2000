using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackbar : MonoBehaviour
{
    public attackmaker Attackmaker;
    public bool[] c = new bool[40];
    public Rigidbody2D rb;
    private Vector2 moveings;
    public GameObject[] d = new GameObject[40];
    public int strength;
    public heartmove_remastered hearts;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive (false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool turn = Attackmaker.myturn;
        if(turn == false){
            transform.position = (new Vector2(277,-45));
            c[1] = false;
            c[0] = false;
            gameObject.SetActive (false);
        }
    }
    public void Startsss()
    {
        bool turn = Attackmaker.myturn;
        if(turn == true){
        gameObject.SetActive (true);
        c[0] = false;
        }
        if(turn == false){
            transform.position = (new Vector2(277,-45));
            c[1] = false;
            c[0] = false;
            gameObject.SetActive (false);
        }
    }
    public void back()
    {
        gameObject.SetActive (false);
    }
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Return) && c[1] == false)
        {
            rb.MovePosition(rb.position + moveings);
        }
        if (Input.GetKeyDown(KeyCode.Return) && c[1] == false&& hearts.presseds == false)
        {
            c[1] = true;
            d[0].GetComponent<slash_remastered>().slash(strength);
            c[0] = true;
            hearts.presseds = true;
        }
        if (transform.position.x >= 266)
        {
            strength = 1;
            moveings = new Vector2(-14.5f,0);
        }
        if (transform.position.x <= -266)
        {
            strength = 1;
            moveings = new Vector2(14.5f,0);
        }
        if (transform.position.x <= 212&&transform.position.x >= -21)
        {
            strength = 2;
        }
        if (transform.position.x <= 26&&transform.position.x >= -20)
        {
            strength = 3;
        }
        if (transform.position.x <= -23&&transform.position.x >= -95.6)
        {
            strength = 2;
        }
    }
}

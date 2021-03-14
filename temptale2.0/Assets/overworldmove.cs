using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overworldmove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Sprite[] soulsprite;
    public Sprite sprite;
    public SpriteRenderer rd;
    public Animator anim; 
    public GameObject[] dialogs;
    public static int move;
    public bool stop;
    public bool encount;
    public static int nowbattle;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static int moveget(string a,int b)
    {
        if (a =="=")
        {
            move =b;
        }
        if (a =="+")
        {
            move +=b;
        }
        return move; 
    }
    public static int nowbattleget()
    {
        return nowbattle;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (stop==false&&encount==false)
        {
           if (Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.RightArrow)&&!Input.GetKey(KeyCode.DownArrow))
        {
            sprite = soulsprite[2];
            rb.MovePosition(rb.position + new Vector2(0,2));
            move++;
            anim.SetInteger("d", 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.RightArrow)&&!Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + new Vector2(-2,0));
            move++;
            sprite = soulsprite[1];
            anim.SetInteger("d", 1);
        }
        if (Input.GetKey(KeyCode.RightArrow)&&!Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + new Vector2(2,0));
            move++;
            sprite = soulsprite[3];
            anim.SetInteger("d", 3);
        }
        if (Input.GetKey(KeyCode.DownArrow)&&!Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.RightArrow))
        {
            sprite = soulsprite[0];
            rb.MovePosition(rb.position + new Vector2(0,-2));
            move++;
            anim.SetInteger("d", 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)&&Input.GetKey(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + new Vector2(-2,2));
            move++;
            anim.SetInteger("d", 2); 
        }
        if (Input.GetKey(KeyCode.RightArrow)&&Input.GetKey(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + new Vector2(2,2));
            move++;
            anim.SetInteger("d", 2); 
        }
        if (Input.GetKey(KeyCode.RightArrow)&&Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + new Vector2(2,-2));
            move++;
            anim.SetInteger("d", 0); 
        }
        if (Input.GetKey(KeyCode.LeftArrow)&&Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + new Vector2(-2,-2));
            move++;
            anim.SetInteger("d", 0); 
        }
        if (Input.GetKey(KeyCode.UpArrow)&&Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + new Vector2(0,-2));
            anim.SetInteger("d", 2);
            move++;
            rb.MovePosition(rb.position + new Vector2(0,2));
            move++;
            anim.SetInteger("d", 0);
        }
        }
        if (!Input.GetKey(KeyCode.DownArrow)&&!Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetInteger("d", 99); 
        } 
        rd.sprite = sprite;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("teleport"))
        {
            other.gameObject.GetComponent<teleport>().teleports();
        }
        if (other.gameObject.CompareTag("encounter"))
        {
            nowbattle = other.gameObject.GetComponent<dead>().type;
            encount = true;
            other.gameObject.SetActive(false);
            dialogs[0].GetComponent<onoff>().on(true);
            dialogs[1].GetComponent<DialogueBassclass.TEXTS>().Texts("howdy",0);
        }
    }
}

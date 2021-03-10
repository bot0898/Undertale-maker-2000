using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartmove_remastered : MonoBehaviour
{
    private float speed;
    public int soultype;
    private int flap;
    public int fflap;
    private bool gravitysignal;
    public Sprite[] soulsprite;
    public Rigidbody2D rb;
    public SpriteRenderer rd;
    public bool firstmove;
    private float orvy;
    private float orvx;
    private Vector2 gravityblue;
    private bool isground;
    public int[] a = new int[40];
    public float[] b = new float[40];
    public bool[] c = new bool[40];
    public GameObject[] d = new GameObject[40];
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private bool pressing;
    public Vector3 positions;
    public attackmaker Attackmaker;
    public AudioClip sound2;
    public AudioSource audioSource;
    private bool pressed;
    public bool presseds;
    public float speedf;
    public int[] skips = new int[4];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.Return) && presseds == true)
        {
            presseds = false;
        }
        if (Attackmaker.myturn == false)
        {
            if (c[0] == false)
            {
                rb.MovePosition(new Vector2(0,-45));
                c[0] =true;
            }
            transform.localScale = new Vector3(100, 100, 1);
            speed = speedf;
            c[1] = false;
            if (soultype == 1 )
            {
                rd.sprite = soulsprite[0];
                if (firstmove == true)
                {
                    moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
                    moveVelocity = moveInput.normalized * speed;
                }
                if (gravitysignal == false)
                {
                    rb.MovePosition(rb.position + moveVelocity);
                }else if (gravitysignal == true &&a[0] <= 100)
                {
                    Vector2 gravitymove = new Vector2(0,-2);
                    rb.MovePosition(rb.position + gravitymove + moveVelocity);
                    a[0]++;
                }
            }
            if (soultype == 2 )
            {
                rd.sprite = soulsprite[1];
                transform.eulerAngles = (new Vector3(0,0,0));
                gravityblue = new Vector2(0,-2);
                if (flap != fflap && firstmove == true)
                {
                    speed = speedf;
                    moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
                }
                if (flap == fflap)
                {
                    speed = speedf/3;
                    moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),0);
                }
                Vector2 bluemoveVelocity = moveInput.normalized * speed;
                if (gravitysignal == false )
                {
                    rb.MovePosition(rb.position + bluemoveVelocity);
                }
                if(!Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.RightArrow)&&pressing == false ||flap == fflap)
                {
                    b[0] -= 0.45f;
                    gravityblue = new Vector2(0,b[0]);
                    rb.MovePosition(rb.position + gravityblue + bluemoveVelocity);   
                }
                if (isground == false && flap != fflap)
                {
                    flap += 1;
                }
                if (flap != 0 && !Input.GetKey(KeyCode.UpArrow))
                {
                    flap = fflap;
                }
                if (!Input.GetKey(KeyCode.UpArrow))
                {
                    pressing = false;
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    pressing = true;
                }
                if (isground == true)
                {
                    pressing = true;
                }
            }
            if(soultype == 3 && firstmove == true)
            {
                speed = speedf;
                rd.sprite = soulsprite[2];
                if (Input.GetAxisRaw("Vertical")!=0 && Input.GetAxisRaw("Horizontal")== 0)
                {
                    orvy = 0f;
                    orvx = 0f;
                    orvy = Input.GetAxisRaw("Vertical");
                }
                if (Input.GetAxisRaw("Horizontal")!=0 && Input.GetAxisRaw("Vertical")== 0)
                {
                    orvx = 0f;
                    orvy = 0f;
                    orvx = Input.GetAxisRaw("Horizontal");
                }
                if (Input.GetAxisRaw("Horizontal")!=0 && Input.GetAxisRaw("Vertical") != 0)
                {
                    orvx = 0f;
                    orvy = 0f;
                    orvx = Input.GetAxisRaw("Horizontal");orvy = Input.GetAxisRaw("Vertical");
                }
                Vector2 orangemoveVelocity = new Vector2(orvx,orvy) * speed;
                rb.MovePosition(rb.position + orangemoveVelocity);
            }   
        }
        if (Attackmaker.myturn == true && Attackmaker.ends == false)
        {
            transform.localScale = new Vector3(150, 150, 1);
            c[0] = false;
            if (c[2] == false && c[1] == false)
            {
                d[0].GetComponent<DialogueBassclass.dialogs>().turn(Attackmaker.turn);
                c[2] = true;
            }
            if(Input.GetKey(KeyCode.LeftArrow) && pressed == false && c[1] == false&&c[7] == false&&c[10] == false&&c[11] == false){
                a[1] -= 1;
                audioSource.PlayOneShot(sound2);
            }
            if(Input.GetKey(KeyCode.RightArrow) && pressed == false && c[1] == false&&c[7] == false&&c[10] == false&&c[11] == false){
                a[1] += 1;
                audioSource.PlayOneShot(sound2);
            }
            d[3].GetComponent<button>().yellowbutton(a[1]);
            d[4].GetComponent<button>().yellowbutton(a[1]);
            d[5].GetComponent<button>().yellowbutton(a[1]);
            d[6].GetComponent<button>().yellowbutton(a[1]);
            if (a[1] == skips[0])
            {
                if (c[1] == false&&skips[0] != 1)
                {
                transform.position = new Vector2(-288,-198);
                }
                if (Input.GetKey(KeyCode.Return) && c[1] == false)
                {
                    presseds = true;
                    d[0].GetComponent<DialogueBassclass.dialogs>().fight();
                    c[1] = true;
                }
            }
            if (c[1] == true||c[7] == true)
            {
            transform.position = new Vector2(-257.3f,5);
            }
            if (Input.GetKey(KeyCode.Return) && c[1] == true &&presseds == false)
            {
                presseds = true; 
                d[0].GetComponent<DialogueBassclass.dialogs>().off(); 
                d[1].GetComponent<command>().fight(); 
                d[2].GetComponent<attackbar>().Startsss();
                c[3] = true;
            }
            if (c[3] == true)
            {
                transform.position = new Vector2(-600f,0); 
            }
            if (Input.GetKey(KeyCode.RightControl)&&c[12] == false&&c[9] == false)
            {
                presseds = true; 
                d[0].GetComponent<DialogueBassclass.dialogs>().turn(Attackmaker.turn);
                c[1] = false;
                c[7] = false; 
                c[8] = false;
                c[9] = false;
                c[10] = false;
                c[11] = false;
                a[2] = 0;
                c[12]= true;
            }
            if (!Input.GetKey(KeyCode.RightControl))
            {
                c[12]= false;
            }
            if (a[1] == skips[1])
            {
                if (c[1] == false&&c[7] == false&c[8] == false)
                {
                    transform.position = new Vector2(-136,-198);
                }
                if (Input.GetKey(KeyCode.Return)&&presseds == false&&c[7] == false)
                {
                   presseds = true;
                   d[0].GetComponent<DialogueBassclass.dialogs>().fight();
                   c[7] = true; 
                }
                if (Input.GetKey(KeyCode.Return) && c[7] == true &&presseds == false&&c[8] == false)
                {
                    presseds = true;
                    d[0].GetComponent<DialogueBassclass.dialogs>().act();
                    c[8] = true;
                }
                if (c[8] == true)
                {
                    if (a[2]==0)
                    {
                        transform.position = new Vector2(-257.3f,5.6f);
                        if (Input.GetKey(KeyCode.Return)&&presseds == false)
                        {
                            d[0].GetComponent<DialogueBassclass.dialogs>().check();
                            c[9] = true;
                            presseds = true;
                        }
                    }
                    if (a[2]==1)
                    {
                        transform.position = new Vector2(144f,5.6f);
                        if (Input.GetKey(KeyCode.Return)&&presseds == false)
                        {
                            d[0].GetComponent<DialogueBassclass.dialogs>().acting(1);
                            c[9] = true;
                            presseds = true;
                        }
                    }
                    if (a[2]==2)
                    {
                        transform.position = new Vector2(-248f,-86.2f);
                        if (Input.GetKey(KeyCode.Return)&&presseds == false)
                        {
                            d[0].GetComponent<DialogueBassclass.dialogs>().acting(2);
                            c[9] = true;
                            presseds = true;
                        }
                    }
                    if (a[2]==3)
                    {
                        transform.position = new Vector2(141f,-86.2f);
                        if (Input.GetKey(KeyCode.Return)&&presseds == false)
                        {
                            d[0].GetComponent<DialogueBassclass.dialogs>().acting(3);
                            c[9] = true;
                            presseds = true;
                        }
                    }
                    if (pressed == false &&Input.GetKey(KeyCode.RightArrow)&&c[9] == false)
                    {
                        a[2] += 1;
                    }
                    if (pressed == false &&Input.GetKey(KeyCode.LeftArrow)&&c[9] == false)
                    {
                        a[2] += -1;
                    }   
                    if (c[9] == true)
                    {
                      a[2] = 0;  
                    }                
                }
                if (a[2]==4)
                {
                    a[2] = 0;
                }
                if (a[2]==-1)
                {
                    a[2] = 3;
                }
            }
            if (a[2]==4)
            {
                a[2] = 0;
            }
            if (a[2]==-1)
            {
                a[2] = 3;
            }
            if (a[1] == skips[2])
            {
                if (c[1] == false&&c[7] == false&&c[10] == false)
                {
                    transform.position = new Vector2(13,-198);
                }
                if (Input.GetKey(KeyCode.Return) && presseds == false&&c[10] == false)
                {
                    presseds = true;
                    d[0].GetComponent<DialogueBassclass.dialogs>().item();
                    c[10] = true;
                }
                if (c[10] == true)
                { 
                    transform.position = new Vector2(-257.3f,5.6f);
                    if (Input.GetKey(KeyCode.Return)&&presseds == false)
                    {
                        d[0].GetComponent<DialogueBassclass.dialogs>().items(0,101,"item1");
                        c[9] = true;
                        presseds = true;
                    }
                }
            }
            if (a[1] == skips[3])
            {
                if (c[1] == false&&c[7] == false&&c[11] == false&&c[10] == false)
                {
                    transform.position = new Vector2(163,-198);
                }

                if (Input.GetKey(KeyCode.Return) && presseds == false&&c[11] == false)
                {
                    transform.position = new Vector2(-257.3f,5.6f);
                    presseds = true;
                    d[0].GetComponent<DialogueBassclass.dialogs>().mercy();
                    c[11] = true;
                }
            }
            if (a[1] == skips[3]+1)
            {
                a[1] = 0;
            }
            if (a[1] <= -1)
            {
                a[1] = 3;
            }
            if (pressed == true && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                pressed = false;
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            {
                pressed = true;
            }
            
        }
        if (Attackmaker.myturn == false)
        {
            d[0].GetComponent<DialogueBassclass.dialogs>().on(); 
            d[1].GetComponent<command>().back(); 
            c[0] = false;
            c[1] = false;
            c[2] = false;
            c[3] = false;
            c[7] = false; 
            c[8] = false;
            c[9] = false;
            c[10] = false;
            c[11] = false;
            c[13] = false;
            a[2] = 0;
        }
        if (c[6] == true)
        {
            rb.MovePosition(new Vector2(0f,-45));
            transform.position = new Vector2(0f,-45);
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "floor")
        {
            isground = false;
        } 
        if (other.gameObject.tag == "roof" && soultype == 4)
        {
            isground = false;
        }  
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            flap = 0;
            b[0] = 0f;
            isground = true;
        } 
        if (other.gameObject.tag == "roof" && soultype == 4)
        {
            flap = 0;
            b[0] = 0f;
            isground = true;
        }  
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "floor" && soultype == 2)
        {
            flap = 0;
            b[0] = 0f;
            isground = true;
        }  
        if (other.gameObject.tag == "roof" && soultype == 4)
        {
            flap = 0;
            b[0] = 0f;
            isground = true;
        }  
        if (other.gameObject.tag == "floor" && soultype == 7)
        {
            flap = 0;
            b[0] = 0f;
            isground = true;
        } 
    }
}

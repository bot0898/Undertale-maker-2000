using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nameenter : MonoBehaviour
{
    public int type;
    public string name;
    public string text;
    public GameObject[] types = new GameObject[6];
    public bool end;
    public bool stop;
    public bool presseds;
    public nameenter[] Nameenter = new nameenter[6];
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = text;
        if (type != 0)
        {
            Nameenter[0] = types[0].GetComponent<nameenter>();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            text = " ";
            end = false;
            presseds = false;
        }
        if (stop == false)
        {
          if (type == 0)
       {
           if (Input.GetKeyDown(KeyCode.Return))
            {
                types[6].GetComponent<nameM>().on(true);
            }
           foreach(char c in Input.inputString) {
				if(c == "\b"[0]) {
                    Debug.Log("BackSpaces");
                    presseds = false;
					text = " ";
                    end = false;
				} else if(c == "\n"[0] || c == "\r"[0]) {
					Debug.Log("EnterOrReturn");
				} else if(c == "\t"[0]) {
					Debug.Log("Tab");
				} else if(Input.GetKeyDown("space")) {
				} else {
					if(c.ToString () != ""&&end == false) {
                        presseds = true;
                        text = c+"";
                        Debug.Log(c);
                        end = true;
					}
				}
			}
       }
       if (type != 0&&Nameenter[0].end == true&&Nameenter[0].presseds == false)
       {
           foreach(var c in Input.inputString) {
				if(c == "\b"[0]) {
					Debug.Log("BackSpace");
                    presseds = false;
                    text = " ";
                    end = false;
				} else if(c == "\n"[0] || c == "\r"[0]) {
					Debug.Log("EnterOrReturn");
				} else if(c == "\t"[0]) {
					Debug.Log("Tab");
				} else if(Input.GetKeyDown("space")) {
					Debug.Log("Space");
				} else {
					if(c.ToString () != ""&&end == false) {
                        presseds = true;
                        text = c+"";
                        Debug.Log(c);
                        end = true;
					}
				}
			}
       }  
    }
        if (!Input.anyKeyDown)
        {
            presseds = false;
        }
       if (Input.GetKeyDown(KeyCode.Return))
       {
           stop = false;
       }
       if (Input.GetKeyDown(KeyCode.RightControl)&&stop == true&&presseds == false)
       {
           stop = false;
       }
    }
    public void on(bool a)
    {
        gameObject.SetActive (a);
        presseds = false;
        end = false;
    }
}

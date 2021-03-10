using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public int menus;
    public bool pressed;
    public bool presseds;
    public itembox Itembox;
    public bool stop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menus == 0&&stop==false)
        {
            GetComponent<TextMesh>().text = "<color=#ffff00>ITEM</color>\nSTATS\nCALL";
        }
        if (menus == 1&&stop==false)
        {
            GetComponent<TextMesh>().text = "ITEM\n<color=#ffff00>STATS</color>\nCALL";
        }
        if (menus == 2&&stop==false)
        {
            GetComponent<TextMesh>().text = "ITEM\nSTATS\n<color=#ffff00>CALL</color>";
        }
        if (!Input.GetKey(KeyCode.UpArrow)&&!Input.GetKey(KeyCode.DownArrow))
        {
            pressed=false;
        }
        if (Input.GetKey(KeyCode.UpArrow)&&pressed==false&&stop==false)
        {
            menus-=1;
            pressed=true;
        }
        if (Input.GetKey(KeyCode.DownArrow)&&pressed==false&&stop==false)
        {
            menus+=1;
            pressed=true;
        }
        if (menus < 0)
        {
            menus = 0;
        }
        if (menus > 2)
        {
            menus = 2;
        }
        if (!Input.GetKey(KeyCode.Return)&&!Input.GetKey(KeyCode.RightControl))
        {
            presseds=false;
        }
        if (Input.GetKey(KeyCode.Return)&&presseds==false&&menus == 0)
        {
            stop =true;
            Itembox.item(true);
            presseds=true;
        }
        if (Input.GetKey(KeyCode.RightControl)&&presseds==false)
        {
            stop =false;
            Itembox.item(false);
            presseds=true;
        }
    }
    public void add()
    {
        //
    }
}

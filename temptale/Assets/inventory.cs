using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class inventory : MonoBehaviour
{
    public int[] inventorys = new int[6];
    public string[] inventorysname = new string[6];
    public int inventoryslot;
    public bool end;
    public GameObject menu;
    public GameObject menu2;
    public overworldmove move;
    public int STATS;
    public float HP;
    // Start is called before the first frame update
    void Start()
    {
        menu.GetComponent<onoff>().on(false);
        data Data = savesystum.Load();
        inventorys = Data.inv;
        inventorysname = Data.invtext;
        settings.LVChange(Data.LV);
        nameM.namechange(name);
        transform.position = new Vector3(Data.position[0],Data.position[1],Data.position[2]);
        Debug.Log("Loaded");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c"))
        {
            menu.GetComponent<onoff>().on(true);
            move.stop = true;
        }
        if (Input.GetKey(KeyCode.RightControl)&&menu2.GetComponent<menu>().presseds == false&&menu2.GetComponent<menu>().stop == false)
        {
            menu.GetComponent<onoff>().on(false);
            move.stop = false;
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("item")&&Input.GetKey(KeyCode.Return))
        {
            other.gameObject.GetComponent<itemdata>().pickup();
            end = false;
            for (int i = 0; i < 6||end==true; i++)
            {
                if (String.IsNullOrEmpty (inventorysname[i])) {
                    inventorys[i] = other.gameObject.GetComponent<itemdata>().type;
                    inventorysname[i] = other.gameObject.GetComponent<itemdata>().name;
                    inventoryslot++;
                    i=6;
		        }   
            }
        }
        if (other.gameObject.CompareTag("save")&&Input.GetKeyDown(KeyCode.Return))
        {
            savesystum.Save(this);
            Debug.Log("saved");
        }
        if (other.gameObject.CompareTag("loadT")&&Input.GetKeyDown(KeyCode.Return))
        {
            data Data = savesystum.Load();
            inventorys = Data.inv;
            inventorysname = Data.invtext;
            settings.LVChange(Data.LV);
            nameM.namechange(name);
            transform.position = new Vector3(Data.position[0],Data.position[1],Data.position[2]);
            Debug.Log("Loaded");
        }
    }
}

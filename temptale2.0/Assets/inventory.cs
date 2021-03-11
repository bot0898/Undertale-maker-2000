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
    public int Savepoint;
    public float HP;
    public Vector2[] SavepointVector2;
    public static Vector2 fightposition;
    public static int killcount;
    // Start is called before the first frame update
    void Start()
    {
        menu.GetComponent<onoff>().on(false);
        fightposition = DialogueBassclass.dialogs.backposget();
        if ( DialogueBassclass.dialogs.winget(null,0) == 0)
        {
            data Data = savesystum.Load();
            inventorys = Data.inv;
            inventorysname = Data.invtext;
            settings.LVChange(Data.LV);
            nameM.namechange(Data.name);
            transform.position = SavepointVector2[Data.positionsavepoint];
            Debug.Log("Loaded");
            DialogueBassclass.TEXTS.HPchange(DialogueBassclass.TEXTS.MHPget(),"=");
        }
        if ( DialogueBassclass.dialogs.winget(null,0) == 1)
        {
            transform.position = fightposition;
        }
        if ( DialogueBassclass.dialogs.winget(null,0) == 2)
        {
            transform.position = fightposition;
            killcount += 1;
        }
    }
    public static Vector2 fightpositionget()
    {
        return fightposition;
    }
    // Update is called once per frame
    void Update()
    {
        fightposition = transform.position;
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
        if (other.gameObject.CompareTag("save")&&Input.GetKey(KeyCode.Return))
        {
            DialogueBassclass.TEXTS.HPchange(DialogueBassclass.TEXTS.MHPget(),"=");
            Savepoint = other.gameObject.GetComponent<saveponit>().point;
            savesystum.Save(this);
            Debug.Log("saved");
        }
        if (other.gameObject.CompareTag("loadT")&&Input.GetKeyDown(KeyCode.Return))
        {
            data Data = savesystum.Load();
            inventorys = Data.inv;
            inventorysname = Data.invtext;
            settings.LVChange(Data.LV);
            nameM.namechange(Data.name);
            transform.position = SavepointVector2[Data.positionsavepoint];
            Debug.Log("Loaded");
        }
    }
}

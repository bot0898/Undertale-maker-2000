
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class data
{
    public int LV;//
    public int[] inv =new int[6];///
    public string[] invtext =new string[6];///
    public int Savetime;//
    public string name;//
    public int Loadtimehere;
    public int positionsavepoint;
    public int[] win=new int[20];

    public data(inventory Inventory)
    {
       inv = Inventory.inventorys;
       invtext = Inventory.inventorysname;
       LV = settings.LVget();
       name = nameM.nameget();
       win = DialogueBassclass.dialogs.winsget(null,null);
       positionsavepoint = Inventory.Savepoint;
       Savetime+=1;
    }
}

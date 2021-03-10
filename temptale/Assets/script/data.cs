
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
    public float[] position = new float[3];

    public data(inventory Inventory)
    {
       inv = Inventory.inventorys;
       invtext = Inventory.inventorysname;
       LV = settings.LVget();
       name = nameM.nameget();
       position[0] = Inventory.transform.position.x;
       position[1] = Inventory.transform.position.y;
       position[2] = Inventory.transform.position.z;
       Savetime+=1;
    }
}

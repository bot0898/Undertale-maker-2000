using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itembox : MonoBehaviour
{
    public DialogueBassclass.TEXTS text;
    public inventory inventorys;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void item(bool a)
    {
        gameObject.SetActive (a);
        if (a==true)
        {
            gameObject.SetActive (a);
            text.text(inventorys.inventorysname[0]+"\n"+inventorys.inventorysname[1]+"\n"+inventorys.inventorysname[2]+"\n"+inventorys.inventorysname[3]+"\n"+inventorys.inventorysname[4]+"\n"+inventorys.inventorysname[5]);
        }
    }
}

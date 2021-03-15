using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    public int type;
    public static int[] wins=new int[20];
    public int[] winsdispl=new int[20];
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive (true);
        winsdispl = wins;
        wins = DialogueBassclass.dialogs.winsget(null,null);
        if (type != 9999)
        {
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 0)
        {
            gameObject.SetActive (true);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 1)
        {
            gameObject.SetActive (false);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 2)
        {
            gameObject.SetActive (false);
        } 
        }
    }
    public static int[] newwinsget()
    {
        return wins;
    }
    // Update is called once per frame
    void Update()
    {
        if (type != 9999)
        {
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 0)
        {
            gameObject.SetActive (true);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 1)
        {
            gameObject.SetActive (false);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 2)
        {
            gameObject.SetActive (false);
        } 
        }
    }
    public void on()
    {
        if (type != 9999)
        {
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 0)
        {
            gameObject.SetActive (true);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 1)
        {
            gameObject.SetActive (false);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 2)
        {
            gameObject.SetActive (false);
        } 
        }
        if (type == 9999)
        {
        foreach (Transform childTransform in this.transform)
        {
            childTransform.gameObject.GetComponent<dead>().on();
        }
        }
    }
}

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
        winsdispl = wins;
        wins = DialogueBassclass.dialogs.winsget();
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 1)
        {
            Destroy (this.gameObject);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 2)
        {
            Destroy (this.gameObject);
        } 
    }
    public static int[] newwinsget()
    {
        return wins;
    }
    // Update is called once per frame
    void Update()
    {
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 1)
        {
            Destroy (this.gameObject);
        }
        if ( DialogueBassclass.dialogs.winget(null,0,type) == 2)
        {
            Destroy (this.gameObject);
        } 
    }
}

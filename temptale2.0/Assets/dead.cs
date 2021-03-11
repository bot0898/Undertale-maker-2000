using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if ( DialogueBassclass.dialogs.winget(null,0) == 1)
        {
            Destroy (this.gameObject);
        }
        if ( DialogueBassclass.dialogs.winget(null,0) == 2)
        {
            Destroy (this.gameObject);
        } 
    }

    // Update is called once per frame
    void Update()
    {
    }
}

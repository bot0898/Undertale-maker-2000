using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class command : MonoBehaviour
{
    public int type;
    public GameObject C_T;
    // Start is called before the first frame update
    void Start()
    {
        if (type == 0)
        {
            gameObject.SetActive (false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        C_T.GetComponent<DialogueBassclass.dialogs>().off();
    }
    public void fight()
    {
        gameObject.SetActive (true);
    }
    public void back()
    {
        gameObject.SetActive (false);
    }
}

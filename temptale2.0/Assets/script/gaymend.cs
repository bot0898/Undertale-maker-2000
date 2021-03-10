using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gaymend : MonoBehaviour
{
    private int esc;
    // Update is called once per frame
    private void Start()
    {
        esc = 0;
    }
    void FixedUpdate()
    {
        if (esc >= 100)
        {
            Application.Quit();
            Debug.Log("end");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            GetComponent<TextMesh>().text = "Quiting.." + esc/50 +"/2";
            esc++;
            esc++;
        }if (!Input.GetKey(KeyCode.Escape))
        {
            GetComponent<TextMesh>().text = "";
            esc = 0;
        }
    }
}

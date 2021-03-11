using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name : MonoBehaviour
{
    public float lV;
    public string names;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = nameM.nameget()+"  LV "+settings.LVget()+"   HP";
    }
}

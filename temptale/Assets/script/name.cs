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
        lV =settings.LVget();
        names = nameM.nameget();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = names+"  LV "+lV+"   HP";
    }
}

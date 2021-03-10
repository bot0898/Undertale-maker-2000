using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdata : MonoBehaviour
{
    public int time;
    public int type;
    public string name;
    public string check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void pickup()
    {
       time-=1; 
       if (time <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

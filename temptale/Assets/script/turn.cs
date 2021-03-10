using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public attackmaker Attackmaker;
    public bool fl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void turns()
    {
        if (fl == false)
        {
            gameObject.SetActive (Attackmaker.myturn);
        }
        if (fl == true)
        {
            if (Attackmaker.myturn == true)
            {
              gameObject.SetActive (false);  
            }
            if (Attackmaker.myturn == false)
            {
              gameObject.SetActive (true);  
            }
        }
    }
}

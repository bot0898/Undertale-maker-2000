using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPbar : MonoBehaviour
{
    public damage Damage;
    private float hope;
    void Start()
    {
    }
    void Update()
    {
        hope = Damage.HP;
        Vector3 hopebar = new Vector3(hope*0.5f, 25, 1);
        gameObject.transform.localScale = hopebar;
    }
}

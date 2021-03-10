using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redhp : MonoBehaviour
{
    public damage Damage;
    private float hope;
    // Start is called before the first frame update
    void Start()
    {
        hope = Damage.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hopebar = new Vector3(hope*0.5f, 25, 1);
        gameObject.transform.localScale = hopebar;
    }
}

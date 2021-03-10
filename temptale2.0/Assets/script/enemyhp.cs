using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhp : MonoBehaviour
{
    public enemy Damage;
    private int hope;
    void Start()
    {
    }
    void Update()
    {
        hope = Damage.HP;
        Vector3 hopebar = new Vector3(hope, 15, 1);
        gameObject.transform.localScale = hopebar;
    }
    public void damage()
    {
        gameObject.SetActive (true);
        StartCoroutine("timer");
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}

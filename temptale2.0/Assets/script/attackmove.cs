using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackmove : MonoBehaviour
{
    public int[] attacktype = new int[10];
    public bool[] active = new bool[100];
    public Vector2 move;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (active[0] == true)
        {
            rb.MovePosition(rb.position + move);
        }
    }
    public void go()
    {
        if (attacktype[0] == 0)
        {
            foreach (Transform childTransform in this.transform)
            {
                childTransform.gameObject.GetComponent<attackmove>().go();
            }
        }
        if (attacktype[0] == 1)
        {
          active[0] = true;
        }
    }
}

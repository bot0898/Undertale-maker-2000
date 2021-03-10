using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Sprite a;
    public Sprite b;
    public SpriteRenderer rd;
    public int type;
    public heartmove_remastered Heartmove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Heartmove.skips[type] == 5)
        {
            gameObject.SetActive (false);
        }
    }
    public void yellowbutton(int num)
    {
        if (Heartmove.skips[type] == num)
        {
            rd.sprite = a;
        }else
        {
            rd.sprite = b;
        }
    }
}

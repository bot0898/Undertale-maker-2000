using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    public int type;
    public static int LV;
    // Start is called before the first frame update
    void Start()
    {
        LV = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (type == 0)
        {
            GetComponent<TextMesh>().text = "LV:"+LV;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKey(KeyCode.Return))
        {
            if (type == 1&&LV!=20)
            {
                LV+=1;
            }
            if (type == 2&&LV>1)
            {
                LV-=1;
            }
            if (type == 3)
            {
                SceneManager.LoadScene("map"); 
            }
        }
    }
    public static int LVget(){
		return LV;
	}
    public static int LVChange(int a){
        LV =a;
		return LV;
	}
}

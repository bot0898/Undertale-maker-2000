using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    public int type;
    public static int LV;
    public data Data;
    // Start is called before the first frame update
    void Start()
    {
        LV = 1;
        Data = savesystum.Load();
    }

    // Update is called once per frame
    void Update()
    {
        nameM.namechange(Data.name);
        if (nameM.nameget() ==""||nameM.nameget() ==null)
        {
            nameM.namechange("chara");
        }
        if (type == 0)
        {
            GetComponent<TextMesh>().text = "LV"+LV;
        }
        if (type == 1)
        {
            GetComponent<TextMesh>().text = ""+nameM.nameget();
        }
        if (type == 2)
        {
            GetComponent<TextMesh>().text = ""+Data.Savetime+"saves";  
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKey(KeyCode.Return))
        {
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

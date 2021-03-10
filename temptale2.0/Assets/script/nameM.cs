using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nameM : MonoBehaviour
{
    public GameObject[] types = new GameObject[6];
    public static string name;
    public string names;
    public bool pressing;
    public int c;
    public string[] banednames;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        names = nameM.nameget();
        if (names == banednames[0]||names == banednames[1]||names == banednames[2]||names == banednames[3]&&names == banednames[4]||names == banednames[5]||names == banednames[6]||names == banednames[7]||names == banednames[8]||names == banednames[9]||names == banednames[10])
        {
            
        }else
        {
            if (Input.GetKeyDown(KeyCode.Return)&&pressing == false)
            {
                SceneManager.LoadScene ("menu1");
            } 
        }
        if (!Input.GetKey(KeyCode.Return))
            {
                pressing = false;
            } 
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            name="";
            types[7].GetComponent<text>().texts("debug");
            GetComponent<TextMesh>().text = name;
            types[0].GetComponent<nameenter>().on(true);
            types[1].GetComponent<nameenter>().on(true);
            types[2].GetComponent<nameenter>().on(true);
            types[3].GetComponent<nameenter>().on(true);
            types[4].GetComponent<nameenter>().on(true);
            types[5].GetComponent<nameenter>().on(true);
            types[6].GetComponent<onoff>().on(true);
        }
    }
    public void on(bool a)
    {
        gameObject.SetActive (a);
        pressing = true;
        name=
        types[0].GetComponent<nameenter>().text.Trim ()
        +types[1].GetComponent<nameenter>().text.Trim ()
        +types[2].GetComponent<nameenter>().text.Trim ()
        +types[3].GetComponent<nameenter>().text.Trim ()
        +types[4].GetComponent<nameenter>().text.Trim ()
        +types[5].GetComponent<nameenter>().text.Trim (); 
        GetComponent<TextMesh>().text = name;
        types[7].GetComponent<text>().texts(name);
        types[0].GetComponent<nameenter>().on(false);
        types[1].GetComponent<nameenter>().on(false);
        types[2].GetComponent<nameenter>().on(false);
        types[3].GetComponent<nameenter>().on(false);
        types[4].GetComponent<nameenter>().on(false);
        types[5].GetComponent<nameenter>().on(false);
        types[6].GetComponent<onoff>().on(false);

    }
    public static string nameget(){
		return name;
	}
    public static string namechange(string s){
		name = s;
        return name;
	}
}

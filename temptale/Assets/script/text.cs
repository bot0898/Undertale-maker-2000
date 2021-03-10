using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void texts(string a)
    {
        if (a =="debug")
        {
            GetComponent<TextMesh>().text = "Hi!Enter the fallen humans name please!";
        }else
        {
           GetComponent<TextMesh>().text = "is this your name?"; 
        }
        if (a =="chara")
        {
            GetComponent<TextMesh>().text = "so..you are choosing the real name?";
        }
        if (a =="toriel")
        {
            GetComponent<TextMesh>().text = "my child choose a deferent name";
        }
        if (a =="sans")
        {
            GetComponent<TextMesh>().text = "oops you can't use that name";
        }
        if (a =="papyru")
        {
            GetComponent<TextMesh>().text = "did someone call my name?";
        }
        if (a =="undyne")
        {
            GetComponent<TextMesh>().text = "GET YOUR OWN NAME!";
        }
        if (a =="metta")
        {
            GetComponent<TextMesh>().text = "mettaton is charging right now";
        }
        if (a =="asgore")
        {
            GetComponent<TextMesh>().text = "if you wish to I will allow it";
        }
        if (a =="asriel")
        {
            GetComponent<TextMesh>().text = "hay!that's my name!";
        }
        if (a =="flowey")
        {
            GetComponent<TextMesh>().text = "";
        }
        if (a =="flowey")
        {
            GetComponent<TextMesh>().text = "";
        }
        if (a =="neo")
        {
            GetComponent<TextMesh>().text = "you want to be weak?";
        }
        if (a =="ex")
        {
            GetComponent<TextMesh>().text = "oh!the rating!";
        }
        if (a =="ex")
        {
            GetComponent<TextMesh>().text = "oh!the rating!";
        }
        if (a =="btt")
        {
            GetComponent<TextMesh>().text = "YOU ARE GOING TO HAVE A TRIPLE BAD TIME";
        }
        if (a =="fdy")
        {
            GetComponent<TextMesh>().text = "oh seriously?";
        }
        if (a =="merg")
        {
            GetComponent<TextMesh>().text = "oh seriously?";
        }
        if (a =="tgt")
        {
            GetComponent<TextMesh>().text = "oh seriously?";
        }
        if (a =="smg4")
        {
            GetComponent<TextMesh>().text = "oh seriously?";
        }
        if (a =="sil")
        {
            GetComponent<TextMesh>().text = "oh seriously?";
        }
        if (a =="us")
        {
            GetComponent<TextMesh>().text = "underswap?";
        }
        if (a =="ts!")
        {
            GetComponent<TextMesh>().text = "ts!underswap?";
        }
        if (a =="ss!")
        {
            GetComponent<TextMesh>().text = "storyshift?";
        }
        if (a =="lb!")
        {
            GetComponent<TextMesh>().text = "lastbreath?";
        }
        if (a =="ass")
        {
            GetComponent<TextMesh>().text = "...";
        }
    }
}

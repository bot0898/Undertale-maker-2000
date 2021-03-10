using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DialogueBassclasss
{
public class gameover : MonoBehaviour
{
    private SpriteRenderer s;
    public int i = 0;
    private void Start()
    {       	
    gameObject.SetActive (false);
    }
    public void end()
    {      	
        gameObject.SetActive (true); 
    }
}
//s.color = new Color(255, 255, 255, i);
}
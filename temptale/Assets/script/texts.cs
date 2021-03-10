using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueBassclass
{
    public class texts : dialogsys
    {
        public attackmaker Attackmaker;
        public string[] input = new string[100];
        public string[] inputjp = new string[100];
        public bool[] c = new bool[40];
        public heartmove_remastered hearts;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Return) && c[Attackmaker.turn] == true&&hearts.presseds == false)
            {
                gameObject.SetActive (false);
                Attackmaker.GetComponent<attackmaker>().startattack();
                hearts.c[6] = false;
            }
        }
        public void text()
        {
            gameObject.SetActive (true);
            StartCoroutine(Dialogue(input[Attackmaker.turn],"",false,0.00005f,null));  
            c[Attackmaker.turn] = true;
        }
    }
}
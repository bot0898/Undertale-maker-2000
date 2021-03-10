using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace DialogueBassclass
{
    public class call : dialogsys
    {
        public float speed;
        private string[] input = new string[20];
        private bool[] oncea = new bool[20];
        private int turn = 0;
        private string front;
        private bool audioon;
        public int lang;
        // Update is called once per frame
        void Start()
        {
            speed = 0.05f;
            if (lang== 0)
            {
               input[0] = "you cannot give\nup just yet...";
                input[1] = "chara!\nstay determinated..."; 
            }
            if (lang == 1)
            {
                input[0] = "あきらめては\nいけない...";
                input[1] = "キャラ！\n決意を力にかえるんだ！"; 
            }
            front = "";
            audioon = true;
            StartCoroutine("timeheart");
        }
        void FixedUpdate()
        {
            if (oncea[1] == false && turn == 1)
            {
                StartCoroutine(Dialogue(input[0],"",false,0.00005f,null));  
                oncea[1] = true;
                turn += 1;
            }
            if (Input.GetKey(KeyCode.Return) && oncea[2] == false && turn == 2 && ends == true)
            {
                ends = false;
                StartCoroutine(Dialogue(input[1],"",false,0.00005f,null));  
                oncea[2] = true;
                turn += 1;
            } 
            if (Input.GetKey(KeyCode.Return) && oncea[3] == false && turn == 3 && ends == true)
            {
                ends = false;
                GetComponent<TextMesh>().text = "";
                oncea[3] = true;
                SceneManager.LoadScene ("battle");
            }
        }
        IEnumerator timeheart()
        {
            yield return new WaitForSeconds(2.5f);
            turn = 1;
        }
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DialogueBassclass
{
    public class dialogs : dialogsys
    {
        public string[] input = new string[100];
        public string name;
        public string namejp;
        public string[] inputjp = new string[100];
        public Font lang_jp;
        public Font lang_en;
        public Material m_jp;
        public Material m_en;
        private int lang;
        private bool[] c = new bool[40];
        public GameObject[] d = new GameObject[40];
        public heartmove_remastered heartmove;
        public int mode;
        public attackmaker Attackmaker;
        public damage Damage;
        public enemy Enemy;
        public Color color1;
        // Start is called before the first frame update
        void Start()
        {
            if (lang == 0)
            {
                GetComponent<TextMesh>().font = lang_en;
                GetComponent<Renderer>().material = m_en; 
            }
            if (lang == 1)
            {
                GetComponent<TextMesh>().font = lang_jp;
                GetComponent<Renderer>().material = m_jp;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (c[0] == true)
            {
                d[0].GetComponent<command>().fight();
            }
            if (c[1] == true && Input.GetKey(KeyCode.Return)&&  heartmove.presseds == false)
            {
                if (mode== 0)
                {
                    Attackmaker.turn += 1;
                }
                heartmove.c[6] = true;
                c[1] = false;
                d[1].GetComponent<attackmaker>().Text();
                heartmove.presseds = true;
            }
            if (c[3] == true&& Input.GetKey(KeyCode.Return)&&  heartmove.presseds == false)
            {
                SceneManager.LoadScene ("map");
            }
            if (Enemy.mercy == true)
            {
                this.gameObject.GetComponent<Renderer>().material.color = color1;
            }
            if (Enemy.mercy == true&&c[4] == true&& Input.GetKey(KeyCode.Return)&&  heartmove.presseds == false)
            {
                heartmove.presseds = true;
                this.GetComponent<DialogueBassclass.dialogs>().youwin(0); 
                Attackmaker.ends = true;
                c[4] = false;
            }
        }
        public void fight()
        {
            if (lang == 0)
            {
              StartCoroutine(Dialogue(name,"* ",false,0.00005f,null));  
            }
            if (lang == 1)
            {
              StartCoroutine(Dialogue(namejp,"* ",false,0.00005f,null));  
            }
        }
        public void act()
        {
            if (lang == 0)
            {
              StartCoroutine(Dialogue("check    			    	act2\n\n\n  act3		    			act4","* ",false,0.00005f,null));  
            }
            if (lang == 1)
            {
              StartCoroutine(Dialogue("act1			    		act2\n\n\n  act3		    			act4","* ",false,0.00005f,null));  
            }
        }
        public void item()
        {
            if (lang == 0)
            {
              StartCoroutine(Dialogue("item1×inf","* ",false,0.00005f,null));  
            }
            if (lang == 1)
            {
              StartCoroutine(Dialogue("item1×inf","* ",false,0.00005f,null));  
            }
        }
        public void mercy()
        {
            if (lang == 0)
            {
              StartCoroutine(Dialogue("mercy","* ",false,0.00005f,null));  
            }
            if (lang == 1)
            {
              StartCoroutine(Dialogue("mercy","* ",false,0.00005f,null));  
            }
            c[4] = true;
        }
        public void items(int a,float heal,string b)
        {
            if (a == 0)
            {
                StartCoroutine(Dialogue("you ate the "+b+"\n  it recovered"+heal+"HP!","* ",false,0.00005f,null));
                c[1] = true;
            }
            if (a == 1)
            {
                StartCoroutine(Dialogue("you ate the "+b+"\n  it recovered"+heal+"HP!","* ",false,0.00005f,null));
                c[1] = true;
            }
            if (a == 2)
            {
                StartCoroutine(Dialogue("you ate the "+b+"\n  it recovered"+heal+"HP!","* ",false,0.00005f,null));
                c[1] = true;
            }
            if (a == 3)
            {
                StartCoroutine(Dialogue("you ate the "+b+"\n  it recovered"+heal+"HP!","* ",false,0.00005f,null));
                c[1] = true;
            }
            Damage.HP += heal;
        }
        public void check()
        {
            StartCoroutine(Dialogue(name+ "ATK1DFS1\ntestmonster","* ",false,0.00005f,null));
            c[1] = true;
        }
        public void acting(int a)
        {
            if (a == 1)
            {
                StartCoroutine(Dialogue("act1","* ",false,0.00005f,null));
                c[1] = true;
            }
            if (a == 2)
            {
                StartCoroutine(Dialogue("act2","* ",false,0.00005f,null));
                c[1] = true;
            }
            if (a == 3)
            {
                StartCoroutine(Dialogue("act3","* ",false,0.00005f,null));
                c[1] = true;
            }
        }
        public void turn(int i)
        {
            gameObject.SetActive (true);
            if (lang == 0)
            {
                StartCoroutine(Dialogue(input[i],"* ",false,0.00005f,null));
            }
            if (lang == 1)
            {
                StartCoroutine(Dialogue(inputjp[i],"* ",false,0.00005f,null));
            }
        }
        public void youwin(int xp)
        {
            gameObject.SetActive (true);
            d[1].GetComponent<attackmaker>().end(); 
            d[0].GetComponent<command>().back(); 
            d[2].GetComponent<attackbar>().back(); 
            StartCoroutine(Dialogue("You won and gained "+xp+" xp \nand 0 gold","* ",false,0.00005f,null));
            c[3] = true;
        }
        public void off()
        {
            gameObject.SetActive (false);
        }
        public void on()
        {
            gameObject.SetActive (true);
        }
    }
}
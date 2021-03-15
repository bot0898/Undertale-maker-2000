using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DialogueBassclass
{
    public class TEXTS : dialogsys
    {
        public string LayerName;
        public int SortingOrder;
        public int type;
        public bool[] texts = new bool[100];
        public GameObject c;
        public GameObject d;
        public AudioClip[] sound1;
        //public AudioSource audioSource;
        public static float HP;
        public static float MHP;
        // Start is called before the first frame update
        void Start()
        {
            this.GetComponent<MeshRenderer>().sortingLayerName = LayerName;
            //Order in Layerの数値
            this.GetComponent<MeshRenderer>().sortingOrder = SortingOrder;
            if (type == 1)
            {
                if (nameM.nameget() ==""||nameM.nameget() ==null)
                {
                    nameM.namechange("chara");
                }
                if (settings.LVget() == 0||settings.LVget() == null)
                {
                    settings.LVChange(1);
                    MHP = 99;
                }
                if (settings.LVget() == 20)
                {
                    MHP = 99;
                }
                if (settings.LVget() == 19)
                {
                    MHP = 92;
                }
                if (settings.LVget() == 18)
                {
                    MHP = 88;
                }
                if (settings.LVget() == 17)
                {
                    MHP = 84;
                }
                if (settings.LVget() == 16)
                {
                    MHP = 80;
                }
                if (settings.LVget() == 15)
                {
                    MHP = 76;
                }
                if (settings.LVget() == 14)
                {
                    MHP = 72;
                }
                if (settings.LVget() == 13)
                {
                    MHP = 68;
                }
                if (settings.LVget() == 12)
                {
                    MHP = 64;
                }
                if (settings.LVget() == 11)
                {
                    MHP = 60;
                }
                if (settings.LVget() == 10)
                {
                    MHP = 56;
                }
                if (settings.LVget() == 9)
                {
                    MHP = 52;
                }
                if (settings.LVget() == 8)
                {
                    MHP = 48;
                }
                if (settings.LVget() == 7)
                {
                    MHP = 44;
                }
                if (settings.LVget() == 6)
                {
                    MHP = 40;
                }
                if (settings.LVget() == 5)
                {
                    MHP = 36;
                }
                if (settings.LVget() == 4)
                {
                    MHP = 32;
                }
                if (settings.LVget() == 3)
                {
                    MHP = 28;
                }
                if (settings.LVget() == 2)
                {
                    MHP = 24;
                }
                if (settings.LVget() == 1)
                {
                    MHP = 20;
                }
                HP = MHP;
                GetComponent<TextMesh>().text = nameM.nameget()+"\n<size=49>LV:"+settings.LVget()+"\nHP "+HP+"/"+MHP+"\nG 5</size>";
            }
        }
        public static float HPchange(float s,string mp)
        {
            if (mp == "=")
            {
                HP = s;
            }
            if (mp == "+")
            {
                HP += s;
            }
            if (mp == "-")
            {
                HP -= s;
            }
        return HP;
	    }
        public static float MHPget()
        {
        return MHP;
	    }
        // Update is called once per frame
        void Update()
        {
            if (type == 1)
            {
                if (nameM.nameget() ==""||nameM.nameget() ==null)
                {
                    nameM.namechange("chara");
                }
                if (settings.LVget() == 0||settings.LVget() == null)
                {
                    settings.LVChange(1);
                    MHP = 99;
                }
                if (settings.LVget() == 20)
                {
                    MHP = 99;
                }
                if (settings.LVget() == 19)
                {
                    MHP = 92;
                }
                if (settings.LVget() == 18)
                {
                    MHP = 88;
                }
                if (settings.LVget() == 17)
                {
                    MHP = 84;
                }
                if (settings.LVget() == 16)
                {
                    MHP = 80;
                }
                if (settings.LVget() == 15)
                {
                    MHP = 76;
                }
                if (settings.LVget() == 14)
                {
                    MHP = 72;
                }
                if (settings.LVget() == 13)
                {
                    MHP = 68;
                }
                if (settings.LVget() == 12)
                {
                    MHP = 64;
                }
                if (settings.LVget() == 11)
                {
                    MHP = 60;
                }
                if (settings.LVget() == 10)
                {
                    MHP = 56;
                }
                if (settings.LVget() == 9)
                {
                    MHP = 52;
                }
                if (settings.LVget() == 8)
                {
                    MHP = 48;
                }
                if (settings.LVget() == 7)
                {
                    MHP = 44;
                }
                if (settings.LVget() == 6)
                {
                    MHP = 40;
                }
                if (settings.LVget() == 5)
                {
                    MHP = 36;
                }
                if (settings.LVget() == 4)
                {
                    MHP = 32;
                }
                if (settings.LVget() == 3)
                {
                    MHP = 28;
                }
                if (settings.LVget() == 2)
                {
                    MHP = 24;
                }
                if (settings.LVget() == 1)
                {
                    MHP = 20;
                }
                HP = MHP;
                GetComponent<TextMesh>().text = nameM.nameget()+"\n<size=49>LV:"+settings.LVget()+"\nHP "+HP+"/"+MHP+"\nG 5</size>";
            }
            if (Input.GetKey(KeyCode.Return)&&texts[0] == true)
            {
                texts[0] = false;
                StartCoroutine(flash("boss battle"));
            }
        }
        IEnumerator flash(string load)
        {
            yield return new WaitForSeconds(0.1f);
            d.GetComponent<onoff>().on(true);
            audioSource.PlayOneShot(sound1[0]);
            yield return new WaitForSeconds(0.1f);
            d.GetComponent<onoff>().on(false);
            audioSource.PlayOneShot(sound1[0]);
            yield return new WaitForSeconds(0.1f);
            d.GetComponent<onoff>().on(true);
            audioSource.PlayOneShot(sound1[0]);
            yield return new WaitForSeconds(0.1f);
            d.GetComponent<onoff>().on(false);
            audioSource.PlayOneShot(sound1[0]);
            yield return new WaitForSeconds(0.1f);
            d.GetComponent<onoff>().on(true);
            audioSource.PlayOneShot(sound1[0]);
            yield return new WaitForSeconds(0.1f);
            d.GetComponent<onoff>().on(false);
            audioSource.PlayOneShot(sound1[1]);
            yield return new WaitForSeconds(0.25f);
            c.GetComponent<overworldmove>().dialogs[0].GetComponent<onoff>().on(false);
            SceneManager.LoadScene (load);
        }
        public void text(string a)
        {
            GetComponent<TextMesh>().text = a;
        }
        public void flashs(string a)
        {
            StartCoroutine(flash(a));
        }
        public void fontchange(Font fonts,Material m)
        {
            GetComponent<TextMesh>().font = fonts;
            GetComponent<Renderer>().material = m; 
        }
        public void Texts(string a,int b)
            {
                gameObject.SetActive (true);
                StartCoroutine(Dialogue(a," ",false,0.1f,null));  
                texts[b] = true;
            }
    }
}
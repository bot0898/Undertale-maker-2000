using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damages : MonoBehaviour
{
    public int type;
    public SpriteRenderer rd;
    public Sprite[] damagesprite = new Sprite[14];
    public char[] ca = new char[1];
    public char[] cs = new char[4];
    // Start is called before the first frame update
    void Start()
    {
        if (type == 4)
        {
        gameObject.SetActive (false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void damage(string a)
    {
        gameObject.SetActive (true);
        if (type != 4)
        {
            for (int b = 0; b < a.Length; b++)
        {
            for (int i = 0; i < 10; i++)
            {
                string s = i.ToString("0");
                char[] c = s.ToCharArray();
                 cs = a.ToCharArray();
                 if (a.Length != 1 && cs[0] != ca[0])
                 {
                    if (type == 0)
                    {
                        if (a.Length == 4)
                        {
                            if (cs[3] == c[0])
                            {
                                rd.sprite = damagesprite[i];
                            } 
                            if (cs[3] == ca[0])
                            {
                                gameObject.SetActive (false);
                            }  
                        }
                        if (a.Length == 1)
                        {
                            gameObject.SetActive (false);
                        }
                        if (a.Length == 2)
                        {
                            gameObject.SetActive (false);
                        }
                        if (a.Length == 3)
                        {
                            gameObject.SetActive (false);
                        }
                    }
                    if (type == 1)
                    {
                        if (a.Length == 3)
                        {
                            if (cs[0] == c[0])
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                        if (a.Length == 4)
                        {
                            if (cs[1] == c[0]&& a.Length == 4)
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                        if (a.Length == 2)
                        {
                            gameObject.SetActive (false);
                        }
                        if (a.Length == 1)
                        {
                            gameObject.SetActive (false);
                        }
                        if (cs[1] == ca[0]&&cs[0] == ca[0])
                        {
                            gameObject.SetActive (false);
                        }
                    }
                    if (type == 2)
                    {
                        if (a.Length == 2)
                        {
                            if (cs[0] == c[0]&& a.Length == 2)
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                        if (a.Length == 4)
                        {
                        if (cs[2] == c[0]&& a.Length == 4)
                        {
                            rd.sprite = damagesprite[i];
                        }
                        }
                        if (a.Length == 3)
                        {
                        if (cs[1] == c[0]&& a.Length == 3)
                        {
                            rd.sprite = damagesprite[i];
                        }
                        }
                        if (a.Length == 1)
                        {
                            gameObject.SetActive (false);
                        }
                        if (cs[1] == ca[0] &&cs[0] == ca[0]&&cs[2] == ca[0])
                        {
                            gameObject.SetActive (false);
                        }
                    }
                    if (type == 3)
                    {
                        if (a.Length == 4)
                        {
                            if (cs[3] == c[0])
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                        if (a.Length == 3)
                        {
                            if (cs[2] == c[0])
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                        if (a.Length == 2)
                        {
                            if (cs[1] == c[0])
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                        if (a.Length == 1)
                        {
                            if (cs[0] == c[0])
                            {
                                rd.sprite = damagesprite[i];
                            }
                        }
                    }   
                 }else
                 {
                    if (type == 0)
                    {
                        rd.sprite = damagesprite[10];
                    } 
                    if (type == 1)
                    {
                        rd.sprite = damagesprite[11];
                    } 
                    if (type == 2)
                    {
                        rd.sprite = damagesprite[12];
                    } 
                    if (type == 3)
                    {
                        rd.sprite = damagesprite[13];
                    } 
                }
            }
        }
        if (type == 4)
        {
            foreach (Transform childTransform in this.transform)
            {
                childTransform.gameObject.GetComponent<damages>().damage(a);
            }
            StartCoroutine("timer");
        }  
        }
        if (type == 4)
        {
            foreach (Transform childTransform in this.transform)
            {
                childTransform.gameObject.GetComponent<damages>().damage(a);
            }
            StartCoroutine("timer");
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}

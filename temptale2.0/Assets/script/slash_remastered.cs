using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slash_remastered : MonoBehaviour
{
    public GameObject[] d = new GameObject[40];
    public Animator anim; 
    private SpriteRenderer rd;
    public Sprite reset;
    private bool resets;
    public attackmaker Attackmaker;
    public int[] a = new int[2];
    private string damages;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      if (resets == true)
      {
          //rd.sprite = reset;
      }  
    }
    public void slash(int c)
    {
        gameObject.SetActive (true);
        StartCoroutine(sl(c));
    }
    IEnumerator sl(int b)
    {
        damage = Random.Range (a[0], a[1]);
        damage *= b;
        damages = damage.ToString();
        anim.SetBool("slash", true);
        yield return new WaitForSeconds(0.8f);
        d[0].GetComponent<damages>().damage(damages);
        d[2].GetComponent<enemy>().damage(damage);
        d[3].GetComponent<enemyhp>().damage();
        anim.SetBool("slash", false);
        Attackmaker.turn += 1;
        yield return new WaitForSeconds(1f);
        d[1].GetComponent<attackmaker>().Text();
        yield return new WaitForSeconds(0.7f);
        gameObject.SetActive (false); 
    }
}

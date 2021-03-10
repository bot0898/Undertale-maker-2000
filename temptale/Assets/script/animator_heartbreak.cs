using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueBassclasss
{
public class animator_heartbreak : MonoBehaviour
{
    private Animator anim; 
    [SerializeField] private GameObject Gaymover;
    public AudioClip sound2;
    public AudioSource audioSource; 
    public AudioClip sound3;
    public AudioSource audioSources; 
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("break", true);
        StartCoroutine("timeheart");
    }
    //Destroy (this.gameObject); 
    // Update is called once per frame
    IEnumerator timeheart()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(sound2);
        yield return new WaitForSeconds(0.9f);
        yield return new WaitForSeconds(0.6f);
        Gaymover.GetComponent<gameover>().end();
        audioSources.PlayOneShot(sound3);
        gameObject.SetActive (false);
    }
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DialogueBassclass
{
        public class dialogsys : MonoBehaviour
        {
            public AudioClip sound3;
            public bool ends;
            public AudioSource audioSource;
            private bool doing;
            private bool doings;
            private bool waiting;
            // Start is called before the first frame update
            protected IEnumerator Dialogue(string input,string front,bool audioon,float speed,AudioClip sounds)
            {
                GetComponent<TextMesh>().text = front;
                waiting = true;
                yield return new WaitForSeconds(0.05f);
                waiting = false;
                for (int i = 0; i < input.Length|| waiting == true; i++)
                {
                    if (!Input.GetKeyDown(KeyCode.Return)&&!Input.GetKeyDown(KeyCode.RightControl)&&!Input.GetKeyDown(KeyCode.LeftControl)&&waiting == false)
                    {
                        yield return new WaitForSeconds(speed);
                    }
                    if (waiting == true)
                    {
                        GetComponent<TextMesh>().text += "";
                    }
                        if (!Input.GetKeyDown(KeyCode.Return)&&!Input.GetKeyDown(KeyCode.RightControl)&&!Input.GetKeyDown(KeyCode.LeftControl)&&waiting == false|| i > 1&&waiting == false)
                        {
                        GetComponent<TextMesh>().text += input[i];
                        }
                    if (audioon == true&&waiting == false)
                    {
                        audioSource.PlayOneShot(sounds);
                    }
                }
            }
        }
}
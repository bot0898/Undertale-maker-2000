using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
          string Path = Application.persistentDataPath +"/player.NEHEHE";
          if(File.Exists(Path))
          {
          SceneManager.LoadScene ("menu1");  
          }
        }
    }
}

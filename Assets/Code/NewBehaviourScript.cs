using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string keyLog;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            keyLog = "";
            keyLog += "d"; 
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            
            keyLog += "p";
        }

        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            
            keyLog += "u";
        }
        Debug.Log(keyLog);
    }
}

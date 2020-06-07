using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CleatTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Clear time " + Timer.minute.ToString("00") + ":" + ((int)Timer.second).ToString("00") + ":" + ((int)(Timer.prime * 100)).ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

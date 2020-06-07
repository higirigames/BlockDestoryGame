using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesBlockNum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Destroy block:" + ballcont.count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

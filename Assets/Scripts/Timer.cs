using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float prime = 0f;
    public static float second = 0f;
    public static int minute = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        if(second >= 60f)
        {
            minute++;
            second = second - 60f;
            //Limit time
            if (minute >= 3)
            {
                SceneManager.LoadScene("GameClear");
            }
        }
        prime = second % 1;
        //Display time 00:00:00
        GetComponent<Text>().text = minute.ToString("00") + ":" + ((int)second).ToString("00") + ":" + ((int)(prime * 100)).ToString("00");
    }
}

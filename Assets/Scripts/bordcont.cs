using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bordcont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Boardcontroller and Limited movement range
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //gameObject.transform.position -= transform.right * 0.07f;
            gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x - 0.07f, -13, 13), gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //gameObject.transform.position += transform.right * 0.07f;
            gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x + 0.07f, -13, 13), gameObject.transform.position.y, gameObject.transform.position.z);
        }

        //or

        //if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > -13)
        //{
        //    gameObject.transform.position -= transform.right * 0.07f;       
        //}
        //else if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x < 13)
        //{
        //    gameObject.transform.position += transform.right * 0.07f;          
        //}
    }
}

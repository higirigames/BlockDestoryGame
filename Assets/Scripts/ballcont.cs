using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballcont : MonoBehaviour
{
    public static int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 800);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("block"))
        {
            //Destroy block
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);
            //SE
            GetComponent<AudioSource>().Play();
            //Destroy block count
            count++;
            if(count == 55)
            {
                SceneManager.LoadScene("GameClear");
            }

        }

        if (other.gameObject.CompareTag("bottom"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}

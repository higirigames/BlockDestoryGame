using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blockcont : MonoBehaviour
{
    public GameObject blockResources;
    public Transform blockParent;
    public static int NumberOfBlocks;

    void Awake()
    {
        for(int x = 0; x < 11; x++)
        {
            for(int y = 0; y < 5; y++)
            {
                GameObject blocks = Instantiate(blockResources,blockParent);
                blocks.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);
            }
        }
        //Number of blocks
        NumberOfBlocks = 11 * 5;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

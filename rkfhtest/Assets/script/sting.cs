using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sting : MonoBehaviour
{
    public int nowmusic = 0;
    public int chatcout = 0;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DD");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

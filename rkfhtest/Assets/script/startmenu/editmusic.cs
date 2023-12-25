using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class editmusic : MonoBehaviour
{

    public int nowmusic =0;
    [SerializeField] public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        string textString = nowmusic.ToString();
        Debug.Log(textString);
        text.text = textString;
    }
    public void click()
    {
        if (nowmusic == 4)
        {
            nowmusic = 0;
        }
        else
        {
            nowmusic += 1;
        }
    }
}

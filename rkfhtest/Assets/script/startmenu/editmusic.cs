using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class editmusic : MonoBehaviour
{

    [SerializeField] sting sting;
    [SerializeField] public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        sting.nowmusic = 0;
    }

    // Update is called once per frame
    void Update()
    {
        string textString = sting.nowmusic.ToString();
        Debug.Log(textString);
        text.text = textString;
    }
    public void click()
    {
        if (sting.nowmusic == 4)
        {
            sting.nowmusic = 0;
        }
        else
        {
            sting.nowmusic += 1;
        }
    }
}

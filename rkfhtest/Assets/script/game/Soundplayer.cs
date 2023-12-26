using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class Soundplayer : MonoBehaviour
{
    private string path;
    [SerializeField]AudioSource myAudio;
    public AudioClip DNA;
    public AudioClip FMA;
    public AudioClip LEMON;
    public AudioClip WHY;
    public AudioClip ICH;
    public int nowbgm;
    GameObject ee;
    private void Start()
    {
        ee = GameObject.Find("settings");
        nowbgm = ee.GetComponent<sting>().nowmusic;
        
        switch (nowbgm)
        {
            case 0:
                myAudio.clip = DNA; break;
            case 1:
                myAudio.clip = FMA; break;
            case 2:
                myAudio.clip = LEMON; break;
            case 3:
                myAudio.clip = WHY; break;
            case 4:
                myAudio.clip = ICH; break;
        }
        Invoke("getaudio", 2.0f);
    }
    void getaudio()
    {
        
        myAudio.Play();
    }

        
        
    
}
   
 


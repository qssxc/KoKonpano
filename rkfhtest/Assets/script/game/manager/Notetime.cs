using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class Notetime : MonoBehaviour
{
    Stopwatch timer = new Stopwatch();
    public GameJson gameJson;
    Data data;
    Notedata notedata;
    public NoteManager line0;
    public NoteManager line1;
    public NoteManager line2;
    public NoteManager line3;

    List<Notedata> notes = new List<Notedata>();
    private void Start()
    {
        notedata = new Notedata();
        data = gameJson.LoadnotedataFromJson();
        timer.Start();
        StartCoroutine(countTime(0.1f));
    }
    IEnumerator countTime(float delayTime)
    {
        notespawn();
        yield return new WaitForSeconds(delayTime);
        StartCoroutine(countTime(0.1f));
    }
    private void notespawn()
    {
        //UnityEngine.Debug.Log("yes");
       

        foreach ( Notedata data in data.data )
        {
            //UnityEngine.Debug.Log(Math.Round(timer.Elapsed.TotalSeconds, 1));
            
            
             
            if (data.notetime == Math.Round(timer.Elapsed.TotalSeconds, 1))
            {
                UnityEngine.Debug.Log(data.notemode);
                //UnityEngine.Debug.Log(data.notetime);
                //UnityEngine.Debug.Log(data.notenumber);
                switch (data.notenumber)
            {
                case 0:
                        line0.notemode = data.notemode;
                        line0.line_0a = 1;
                    break;
                case 1:
                        line1.notemode = data.notemode;
                        line1.line_1a = 1;
                    break;
                case 2:
                        line2.notemode = data.notemode;
                        line2.line_2a = 1;
                    break;
                case 3:
                        line3.notemode = data.notemode;
                        line3.line_3a = 1;
                    break;
            }
            }

        }
        
    }
}

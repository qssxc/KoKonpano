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
    }
    private void Update()
    {
        double notetimeset = 0;
        double nowtimeset = 0;
        double linenumberset = 0;

        foreach ( Notedata data in data.data )
        {
            UnityEngine.Debug.Log(Math.Round(timer.Elapsed.TotalSeconds, 1));
            linenumberset = data.notenumber;
            notetimeset = data.notetime;
            nowtimeset = Math.Round(timer.Elapsed.TotalSeconds, 1);
        }
        if (notetimeset == nowtimeset)
        {
            switch (linenumberset)
            {
                case 0:
                    line0.line_0a = 1;
                    break;
                case 1:
                    line1.line_1a = 1;
                    break;
                case 2:
                    line2.line_2a = 1;
                    break;
                case 3:
                    line3.line_3a = 1;
                    break;
            }
        }
    }
}

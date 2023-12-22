using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0;
    [SerializeField] int linenumber = 0;
    [SerializeField] Transform tfNoteAppear = null;

    TimingManager theTimingManager;
    EffectManager theEffect;
    public int line_0a = 0;
    public int line_1a = 0;
    public int line_2a = 0;
    public int line_3a = 0;
    public int notemode = 0;

    void Start()
    {
        theTimingManager = GetComponent<TimingManager>();
        theEffect = FindObjectOfType<EffectManager>();
    }
    void Update()
    {       
            if (linenumber == 0)
            {
                if (line_0a == 1)
                {
                    if (notemode == 0)
                    {
                    Debug.Log("shortshort");
                    GameObject t_note = ObjectPool.instance.noteQueue.Dequeue();
                    t_note.transform.position = tfNoteAppear.position;
                    t_note.SetActive(true);

                    theTimingManager.boxNoteList.Add(t_note);
                    line_0a = 0;
                    }
                    if (notemode == 1)
                    {
                    Debug.Log("longlong");
                    GameObject t_note4 = ObjectPool.instance.noteQueue4.Dequeue();
                    t_note4.transform.position = tfNoteAppear.position;
                    t_note4.SetActive(true);
                    Transform toplong = t_note4.transform.GetChild(0);
                    Transform bottomlong = t_note4.transform.GetChild(1);
                    Debug.Log(toplong.transform.position.y);
                    theTimingManager.boxNoteList.Add(t_note4);
                    theTimingManager.longtop.Add(toplong);
                    theTimingManager.longbottom.Add(bottomlong);
                    line_0a = 0;
                    }
                }
            }
            else if (linenumber == 1)
            {
                if (line_1a == 1)
                {
                    if (notemode == 0)
                    {
                    GameObject t_note1 = ObjectPool.instance.noteQueue1.Dequeue();
                    t_note1.transform.position = tfNoteAppear.position;
                    t_note1.SetActive(true);

                    theTimingManager.boxNoteList.Add(t_note1);
                    line_1a = 0;
                    }   
                    if (notemode == 1)
                    {
                    Debug.Log("longlong");
                    GameObject t_note5 = ObjectPool.instance.noteQueue5.Dequeue();
                    t_note5.transform.position = tfNoteAppear.position;
                    t_note5.SetActive(true);
                    Transform toplong = t_note5.transform.GetChild(0);
                    Transform bottomlong = t_note5.transform.GetChild(1);
                    Debug.Log(toplong.transform.position.y);
                    theTimingManager.boxNoteList.Add(t_note5);
                    theTimingManager.longtop.Add(toplong);
                    theTimingManager.longbottom.Add(bottomlong);
                    line_1a = 0;
                    }
                }
            }

            else if (linenumber == 2)
            {
            if (line_2a == 1)
                {
                if (notemode == 0)
                { 
                    GameObject t_note2 = ObjectPool.instance.noteQueue2.Dequeue();
                    t_note2.transform.position = tfNoteAppear.position;
                    t_note2.SetActive(true);

                    theTimingManager.boxNoteList.Add(t_note2);
                    line_2a = 0;
                }
                if (notemode == 1)
                {
                    Debug.Log("longlong");
                    GameObject t_note6 = ObjectPool.instance.noteQueue6.Dequeue();
                    t_note6.transform.position = tfNoteAppear.position;
                    t_note6.SetActive(true);
                    Transform toplong = t_note6.transform.GetChild(0);
                    Transform bottomlong = t_note6.transform.GetChild(1);
                    Debug.Log(toplong.transform.position.y);
                    theTimingManager.boxNoteList.Add(t_note6);
                    theTimingManager.longtop.Add(toplong);
                    theTimingManager.longbottom.Add(bottomlong);
                    line_2a = 0;
                }
            }
            }
            else if (linenumber == 3)
            {
            if (line_3a == 1)
            {
                if (notemode == 0)
                {
                    GameObject t_note3 = ObjectPool.instance.noteQueue3.Dequeue();
                    t_note3.transform.position = tfNoteAppear.position;
                    t_note3.SetActive(true);

                    theTimingManager.boxNoteList.Add(t_note3);
                    line_3a = 0;
                }

                if (notemode == 1)
                {
                    Debug.Log("longlong");
                    GameObject t_note7 = ObjectPool.instance.noteQueue7.Dequeue();
                    t_note7.transform.position = tfNoteAppear.position;
                    t_note7.SetActive(true);
                    Transform toplong = t_note7.transform.GetChild(0);
                    Transform bottomlong = t_note7.transform.GetChild(1);
                    Debug.Log(toplong.transform.position.y);
                    theTimingManager.boxNoteList.Add(t_note7);
                    theTimingManager.longtop.Add(toplong);
                    theTimingManager.longbottom.Add(bottomlong);
                    line_3a = 0;
                }
            }
        }
           
       
    }

   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Note"))
        {
            if (linenumber == 0)
            {
                if (collision.GetComponent<Note>().GetNoteFlag())
                    theEffect.JudgementEffect(4);
                theTimingManager.boxNoteList.Remove(collision.gameObject);
                ObjectPool.instance.noteQueue.Enqueue(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
            if (linenumber == 1)
            {
                if (collision.GetComponent<Note>().GetNoteFlag())
                    theEffect.JudgementEffect(4);
                theTimingManager.boxNoteList.Remove(collision.gameObject);
                ObjectPool.instance.noteQueue1.Enqueue(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
            if (linenumber == 2)
            {
                if (collision.GetComponent<Note>().GetNoteFlag())
                    theEffect.JudgementEffect(4);
                theTimingManager.boxNoteList.Remove(collision.gameObject);
                ObjectPool.instance.noteQueue2.Enqueue(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
            if (linenumber == 3)
            {
                if (collision.GetComponent<Note>().GetNoteFlag())
                    theEffect.JudgementEffect(4);
                theTimingManager.boxNoteList.Remove(collision.gameObject);
                ObjectPool.instance.noteQueue3.Enqueue(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
            if (linenumber == 4)
            {
                if (collision.GetComponent<Note>().GetNoteFlag())
                    theEffect.JudgementEffect(4);
                theTimingManager.boxNoteList.Remove(collision.gameObject);
                
                ObjectPool.instance.noteQueue4.Enqueue(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
        }
    }
}
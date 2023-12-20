using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;
    [SerializeField] int linenumber = 0;
    [SerializeField] Transform tfNoteAppear = null;

    TimingManager theTimingManager;
    EffectManager theEffect;
    public int line_1a = 0;
    

    void Start()
    {
        theTimingManager = GetComponent<TimingManager>();
        theEffect = FindObjectOfType<EffectManager>();
    }
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= 60d / bpm)
        {
            if (linenumber == 0)
            {
                GameObject t_note = ObjectPool.instance.noteQueue.Dequeue();
                t_note.transform.position = tfNoteAppear.position;
                t_note.SetActive(true);

                theTimingManager.boxNoteList.Add(t_note);
                currentTime -= 60d / bpm;
            }
            else if (linenumber == 1)
            {
                if (line_1a == 1)
                {
                    GameObject t_note1 = ObjectPool.instance.noteQueue1.Dequeue();
                    t_note1.transform.position = tfNoteAppear.position;
                    t_note1.SetActive(true);

                    theTimingManager.boxNoteList.Add(t_note1);
                    line_1a = 0;
                }
            }

            else if (linenumber == 2)
            {
                
                GameObject t_note2 = ObjectPool.instance.noteQueue2.Dequeue();
                t_note2.transform.position = tfNoteAppear.position;
                t_note2.SetActive(true);

                theTimingManager.boxNoteList.Add(t_note2);
                currentTime -= 60d / bpm;
            }
            else if (linenumber == 3)
            {
                GameObject t_note3 = ObjectPool.instance.noteQueue3.Dequeue();
                t_note3.transform.position = tfNoteAppear.position;
                t_note3.SetActive(true);

                theTimingManager.boxNoteList.Add(t_note3);
                currentTime -= 60d / bpm;
            }
            else if (linenumber == 4)
            {
                GameObject t_note4 = ObjectPool.instance.noteQueue4.Dequeue();
                t_note4.transform.position = tfNoteAppear.position;
                t_note4.SetActive(true);
                Transform toplong = t_note4.transform.GetChild(0);
                Transform bottomlong = t_note4.transform.GetChild(1);
                
                Debug.Log(toplong.transform.position.y);
                theTimingManager.boxNoteList.Add(t_note4);
                theTimingManager.longtop.Add(toplong);
                theTimingManager.longbottom.Add(bottomlong);

                currentTime -= 60d / bpm;
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
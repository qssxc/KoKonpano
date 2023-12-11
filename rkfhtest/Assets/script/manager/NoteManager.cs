using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform tfNoteAppear = null;

    TimingManager theTimingManager;
    EffectManager theEffect;
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
            GameObject t_note = ObjectPool.instance.noteQueue.Dequeue();
            
            t_note.transform.position = tfNoteAppear.position;
            t_note.SetActive(true);
         
            theTimingManager.boxNoteList.Add(t_note);
            currentTime -= 60d / bpm;
        }
    }

   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yes");
        if (collision.CompareTag("Note"))
        {
            if (collision.GetComponent<Note>().GetNoteFlag())
                theEffect.JudgementEffect(4);
            theTimingManager.boxNoteList.Remove(collision.gameObject);
            ObjectPool.instance.noteQueue.Enqueue(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
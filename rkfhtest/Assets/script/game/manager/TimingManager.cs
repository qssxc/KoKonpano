using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{

    public List<GameObject> boxNoteList = new List<GameObject>();
    public List<Transform> longtop = new List<Transform>();
    public List<Transform> longbottom = new List<Transform>();
    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxs = null;
    
    // Start is called before the first frame update
    EffectManager theEffect;
    ScoreManager theScoreManager;
    Note thenote;
    void Start()
    {
        
        theEffect = FindObjectOfType<EffectManager>();
        theScoreManager = FindObjectOfType<ScoreManager>();
        
        timingBoxs = new Vector2[timingRect.Length];
        
        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.position.y - timingRect[i].rect.height / 2,
                              Center.position.y + timingRect[i].rect.height / 2);
            Debug.Log(Center.position.y);
        }
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    public void CheckTiming()
    {
        Debug.Log("click");
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = boxNoteList[i].transform.position.y;
            
            if (boxNoteList[i].GetComponent<Note>().notemode == 0)
            {
                for (int x = 0; x < timingBoxs.Length; x++)
                {
                    if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                    {
                        Debug.Log("HIT" + x);
                        boxNoteList[i].GetComponent<Note>().HideNote();
                        boxNoteList.RemoveAt(i);

                        if (x < timingBoxs.Length - 1)
                        {
                            theEffect.NoteHitEffect();
                        }
                        theEffect.JudgementEffect(x);
                        return;

                    }
                }
            }
        }

        theEffect.JudgementEffect(timingBoxs.Length);
    }
    public void StartCheckLong()
    {
        Debug.Log("down");
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = longbottom[i].transform.position.y;

            if (boxNoteList[i].GetComponent<Note>().notemode == 1)
            {
                for (int x = 0; x < timingBoxs.Length; x++)
                {
                    if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                    {
                        Debug.Log("LONGHIT" + x);

                        if (x < timingBoxs.Length - 1)
                        {
                            theEffect.NoteHitEffect();
                        }
                        theEffect.JudgementEffect(x);
                        return;

                    }
                }
                
            }
        }

        theEffect.JudgementEffect(timingBoxs.Length);
    }
    public void EndCheckLong()
    {
        Debug.Log("up");
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosX = longtop[i].transform.position.y;
            
            if (boxNoteList[i].GetComponent<Note>().notemode == 1)
            {
                for (int x = 0; x < timingBoxs.Length; x++)
                {

                    if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                    {
                        Debug.Log("HIT" + x);
                        boxNoteList[i].GetComponent<Note>().HideNote();
                        boxNoteList.RemoveAt(i);

                        if (x < timingBoxs.Length - 1)
                        {
                            theEffect.NoteHitEffect();
                        }
                        theEffect.JudgementEffect(x);
                        return;

                    }
                }
            }
        }

        theEffect.JudgementEffect(timingBoxs.Length);
    }
}

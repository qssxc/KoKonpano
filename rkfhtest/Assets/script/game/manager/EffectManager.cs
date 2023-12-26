 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator noteHitAnimator = null;
    string hit = "Hit";
    [SerializeField] Animator judgementAnimator = null;
    [SerializeField] UnityEngine.UI.Image judgementImage = null;
    [SerializeField] Sprite[] judgementSprite = null;
    [SerializeField] TMP_Text text = null;
    GameObject st;
    public int score;
    private void Start()
    {
        st = GameObject.Find("settings");
    }
    public void JudgementEffect(int p_num)
    {
        switch(p_num)
        {
             case 0:
                st.GetComponent<sting>().score += 5;
                text.text = st.GetComponent<sting>().score.ToString();
                break;
            case 1:
                st.GetComponent<sting>().score += 4;
                text.text = st.GetComponent<sting>().score.ToString();
                break;
            case 2:
                st.GetComponent<sting>().score += 3;
                text.text = st.GetComponent<sting>().score.ToString();
                break;
            case 3:
                st.GetComponent<sting>().score += 2;
                text.text = st.GetComponent<sting>().score.ToString();
                break;
            case 4:
                st.GetComponent<sting>().score += 0;
                text.text = st.GetComponent<sting>().score.ToString();
                break;
        }
        judgementImage.sprite = judgementSprite[p_num];
        judgementAnimator.SetTrigger(hit);
        
    }

    public void NoteHitEffect()
    {
        noteHitAnimator.SetTrigger(hit);
    }
}

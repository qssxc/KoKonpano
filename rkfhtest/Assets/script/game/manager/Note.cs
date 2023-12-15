using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 400;
    bool move = true;
    [SerializeField] Animator noteHitAnimator = null;
    UnityEngine.SpriteRenderer noteImage;
    private void Start()
    {
        noteImage = GetComponent<UnityEngine.SpriteRenderer>();
    }
    void OnEnable()
    {
        if (noteImage == null)
            noteImage = GetComponent<UnityEngine.SpriteRenderer>();
        noteImage.enabled = true;
    }
    void Update()
    {
        if(move==true)
            transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
    }
    public void HideNote()
    {
        move = false;
        noteHitAnimator.SetTrigger("Hit");
        Invoke("noteenabled", .2f);
    }
    public void noteenabled()
    {
        move=true;
        noteImage.enabled = false;
    }
    
    public bool GetNoteFlag()
    {
        return noteImage.enabled;
    }
    
}

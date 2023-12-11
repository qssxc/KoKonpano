using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 400;

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
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
    }
    public void HideNote()
    {
        noteImage.enabled = false;
    }
    public bool GetNoteFlag()
    {
        return noteImage.enabled;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool click;
    public GameObject button;
    public Vector2 starpas;
    public Vector2 direction;
    public GameObject target;

    
    private void OnMouseDown()
    {
        target.SendMessage("CheckTiming");
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        starpas = touch.position;
        //        click = false;
        //    }
        //    // Determine direction by comparing the current touch position with the initial one.
        //    if (touch.phase == TouchPhase.Moved)
        //    {
        //        direction = touch.position - starpas;
        //    }

        //    // Report that a direction has been chosen when the finger is lifted.
        //    if (touch.phase == TouchPhase.Ended)
        //    {
        //        click = true;
        //    }

        //}



    }

         
    }


using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class setchat : MonoBehaviour
{
    UnityEngine.TextAsset textAsset;
    public TMP_Text nametext;
    public TMP_Text chattext;
    public chat chatmanaeger;
    static public ChatData ChatData;
    [SerializeField] GameObject Nt;
    [SerializeField] GameObject Et;
    [SerializeField] GameObject Pt;
    [SerializeField] GameObject Mt;
    [SerializeField] GameObject Yt;
    [SerializeField] GameObject HP;
    [SerializeField] GameObject BG;
    [SerializeField] GameObject BG1;
    [SerializeField] GameObject BG2;
    [SerializeField] GameObject BG3;
    [SerializeField] GameObject BG4;
    [SerializeField] GameObject BG5;
    [SerializeField] GameObject BG6;
    [SerializeField] GameObject BG7;
    [SerializeField] GameObject BG8;
    [SerializeField] GameObject BG9;
    [SerializeField] GameObject BG10;
    [SerializeField] GameObject BG11;
    [SerializeField] GameObject BG12;
    [SerializeField] GameObject BG13;
    GameObject st;
    public int chatcount;
    // Start is called before the first frame update
    void Start()
    {
        st = GameObject.Find("settings");
        Debug.Log(st.GetComponent<sting>().chatcout);
        chatcount = st.GetComponent<sting>().chatcout;
        ChatData = chatmanaeger.Loadchatdata();
        Nt.SetActive(false);
        Et.SetActive(false);
        Pt.SetActive(false);
        Mt.SetActive(false);
        Yt.SetActive(false);
        HP.SetActive(false);
        BG.SetActive(false);
        BG1.SetActive(false);
        BG2.SetActive(false);
        BG3.SetActive(false);
        BG4.SetActive(false);
        BG5.SetActive(false);
        BG6.SetActive(false);
        BG7.SetActive(false);
        BG8.SetActive(false);
        BG9.SetActive(false);
        BG10.SetActive(false);
        BG11.SetActive(false);
        BG12.SetActive(false);
        BG13.SetActive(false);

        //Chatstart();
    }

    // Update is called once per frame
    public void Chatstart()
    {      
            nametext.text = ChatData.chatdata[chatcount].name;
            chattext.text = ChatData.chatdata[chatcount].chating;
            chatcount++;
            st.GetComponent<sting>().chatcout = chatcount;
        if( 39<chatcount & chatcount<53)
        {
            Nt.SetActive(true);
        }
        else if (64 < chatcount & chatcount < 53)
        {
            Nt.SetActive(true);
        }
        else
        {
            Nt.SetActive(false);
            Et.SetActive(false);
            Pt.SetActive(false);
            Mt.SetActive(false);
            Yt.SetActive(false);
            HP.SetActive(false);
            BG.SetActive(false);
            BG1.SetActive(false);
            BG2.SetActive(false);
            BG3.SetActive(false);
            BG4.SetActive(false);
            BG5.SetActive(false);
            BG6.SetActive(false);
            BG7.SetActive(false);
            BG8.SetActive(false);
            BG9.SetActive(false);
            BG10.SetActive(false);
            BG11.SetActive(false);
            BG12.SetActive(false);
            BG13.SetActive(false);
        }
    }
    
}

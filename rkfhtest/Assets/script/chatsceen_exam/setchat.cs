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

        Chatstart();
    }

    // Update is called once per frame
    public void Chatstart()
    {      
            nametext.text = ChatData.chatdata[chatcount].name;
            chattext.text = ChatData.chatdata[chatcount].chating;
            chatcount++;
            st.GetComponent<sting>().chatcout = chatcount;
        Nt.SetActive(true);
    }
    
}

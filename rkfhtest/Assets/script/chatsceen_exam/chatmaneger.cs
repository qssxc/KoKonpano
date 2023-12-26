using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class chat : MonoBehaviour
{
    UnityEngine.TextAsset textAsset;
    public Chat Chat;
    public ChatData ChatData;
    // Start is called before the first frame update
    void Start()
    {
        

    }
    public ChatData Loadchatdata()
    {
        textAsset = Resources.Load<UnityEngine.TextAsset>("Chatdata");
        // 파일의 텍스트를 string으로 저장
        // 이 Json데이터를 역직렬화하여 playerData에 넣어줌
        ChatData = JsonUtility.FromJson<ChatData>(textAsset.ToString());
        return ChatData;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class Chat
{
    public string name;
    public string chating;

}
[System.Serializable]
public class ChatData
{
    public List<Chat> chatdata;
}

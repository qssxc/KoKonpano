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
        // ������ �ؽ�Ʈ�� string���� ����
        // �� Json�����͸� ������ȭ�Ͽ� playerData�� �־���
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

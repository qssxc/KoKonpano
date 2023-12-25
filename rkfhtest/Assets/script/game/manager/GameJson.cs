using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class GameJson : MonoBehaviour
{
    TextAsset textAsset;
    // Start is called before the first frame update
    public Notedata notedata;
    public Data data;
    List<Data> dataList = new List<Data>();
    [ContextMenu("To Json Data")] // 컴포넌트 메뉴에 아래 함수를 호출하는 To Json Data 라는 명령어가 생성됨
    public void SavenotedataToJson()
    {
        // ToJson을 사용하면 JSON형태로 포멧팅된 문자열이 생성된다  
        string jsonData = JsonUtility.ToJson(Notetime.data);
        // 데이터를 저장할 경로 지정
        string path = Path.Combine(Application.persistentDataPath, "notedata.json");
        // 파일 생성 및 저장
        File.WriteAllText(path, jsonData);
        

    }
    [ContextMenu("From Json Data")]
    public Data LoadnotedataFromJson()
    {
        if (File.Exists("C:/Users/user/AppData/LocalLow/KoKonpano/rkfhtest/notedata.json"))
        {
            // 데이터를 불러올 경로 지정
            string path = Path.Combine(Application.persistentDataPath, "notedata.json");
            // 파일의 텍스트를 string으로 저장
            string jsonData = File.ReadAllText(path);
            // 이 Json데이터를 역직렬화하여 playerData에 넣어줌
            data = JsonUtility.FromJson<Data>(jsonData);
            return data;
        }
        else
        {
            // 파일이 존재하지 않는 경우
            // 데이터를 불러올 경로 지정
            textAsset = Resources.Load<TextAsset>("Note/Notedata");
            // 파일의 텍스트를 string으로 저장
            // 이 Json데이터를 역직렬화하여 playerData에 넣어줌
            data = JsonUtility.FromJson<Data>(textAsset.ToString());
            return data;
        }
        
    }
    private void Start()
    {
        
        Debug.Log(data);
    }
}
[System.Serializable]
public class Notedata
{
    
    public int notemode;
    public float notelong;
    public int notenumber;
    public float notetime;

}
[System.Serializable]
public class Data
{
    public List<Notedata> data;
}
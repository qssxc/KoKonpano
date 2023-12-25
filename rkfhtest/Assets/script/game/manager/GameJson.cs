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
    [ContextMenu("To Json Data")] // ������Ʈ �޴��� �Ʒ� �Լ��� ȣ���ϴ� To Json Data ��� ��ɾ ������
    public void SavenotedataToJson()
    {
        // ToJson�� ����ϸ� JSON���·� �����õ� ���ڿ��� �����ȴ�  
        string jsonData = JsonUtility.ToJson(Notetime.data);
        // �����͸� ������ ��� ����
        string path = Path.Combine(Application.persistentDataPath, "notedata.json");
        // ���� ���� �� ����
        File.WriteAllText(path, jsonData);
        

    }
    [ContextMenu("From Json Data")]
    public Data LoadnotedataFromJson()
    {
        if (File.Exists("C:/Users/user/AppData/LocalLow/KoKonpano/rkfhtest/notedata.json"))
        {
            // �����͸� �ҷ��� ��� ����
            string path = Path.Combine(Application.persistentDataPath, "notedata.json");
            // ������ �ؽ�Ʈ�� string���� ����
            string jsonData = File.ReadAllText(path);
            // �� Json�����͸� ������ȭ�Ͽ� playerData�� �־���
            data = JsonUtility.FromJson<Data>(jsonData);
            return data;
        }
        else
        {
            // ������ �������� �ʴ� ���
            // �����͸� �ҷ��� ��� ����
            textAsset = Resources.Load<TextAsset>("Note/Notedata");
            // ������ �ؽ�Ʈ�� string���� ����
            // �� Json�����͸� ������ȭ�Ͽ� playerData�� �־���
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
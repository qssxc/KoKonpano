using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class GameJson : MonoBehaviour
{
    // Start is called before the first frame update
    public Notedata notedata;
    public Data data;   
    List<Data> dataList = new List<Data>();
    [ContextMenu("To Json Data")] // ������Ʈ �޴��� �Ʒ� �Լ��� ȣ���ϴ� To Json Data ��� ��ɾ ������
    void SavenotedataToJson()
    {
        // ToJson�� ����ϸ� JSON���·� �����õ� ���ڿ��� �����ȴ�  
        string jsonData = JsonUtility.ToJson(notedata);
        // �����͸� ������ ��� ����
        string path = Path.Combine(Application.dataPath, "notedata.json");
        // ���� ���� �� ����
        File.WriteAllText(path, jsonData);
        

    }
    [ContextMenu("From Json Data")]
    public Data LoadnotedataFromJson()
    {
        // �����͸� �ҷ��� ��� ����
        string path = Path.Combine(Application.dataPath, "notedata.json");
        // ������ �ؽ�Ʈ�� string���� ����
        string jsonData = File.ReadAllText(path);
        // �� Json�����͸� ������ȭ�Ͽ� playerData�� �־���
        data = JsonUtility.FromJson<Data>(jsonData);
        return data;
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
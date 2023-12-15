using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectInfo
{
    public GameObject goPrefab;
    public int count;
    public Transform tfPoolParent;
}
public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    [SerializeField] ObjectInfo[] objectInfo = null;

    public Queue<GameObject> noteQueue = new Queue<GameObject>(); // Pool


    // Start is called before the first frame update
    void Start()
    {
       instance = this;
       noteQueue = InsertQueue(objectInfo[0]);
    }

    Queue<GameObject> InsertQueue(ObjectInfo p_objectInfo)
    {
        Queue<GameObject> temp_Queue = new Queue<GameObject>();
        for (int i = 0; i < p_objectInfo.count; i++)
        {
            GameObject temp_clone = Instantiate(p_objectInfo.goPrefab, transform.position, Quaternion.identity);
            temp_clone.SetActive(false);
            if (p_objectInfo.tfPoolParent != null)
                temp_clone.transform.SetParent(p_objectInfo.tfPoolParent);
            else
                temp_clone.transform.SetParent(this.transform);
            temp_Queue.Enqueue(temp_clone);
        }
        return temp_Queue;
    }
}

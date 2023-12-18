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
    public Queue<GameObject> noteQueue1 = new Queue<GameObject>();
    public Queue<GameObject> noteQueue2 = new Queue<GameObject>();
    public Queue<GameObject> noteQueue3 = new Queue<GameObject>();
    public Queue<GameObject> noteQueue4 = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
       instance = this;
       noteQueue = InsertQueue(objectInfo[0]);
       noteQueue1 = InsertQueue(objectInfo[1]);
       noteQueue2 = InsertQueue(objectInfo[2]);
       noteQueue3 = InsertQueue(objectInfo[3]);
       noteQueue4 = InsertQueue(objectInfo[4]);

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

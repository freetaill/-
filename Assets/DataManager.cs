using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

// �����ϴ� ���
// 1. ������ �����Ͱ� ����
// 2. �����͸� ���̽����� ��ȯ
// 3. ���̽��� �ܺο� ����

// �ҷ����� ���
// 1. �ܺο� ����� ���̽��� ������
// 2. ���̽��� ������ ���·� ��ȯ
// 3. �ҷ��� �����͸� ���

public class PlayerData
{
    public string Name;
    public int fatigue;
    public int Gold;
    public int record;
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public Player nowPlayer = new Player();
    public Animal nowAnimal = new Animal();

    public string path;
    public int nowSlot;

    private void Awake()
    {
        //�̱��� ����
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
        //�̱��� ����

        path = Application.persistentDataPath + "/save";
    }

    void Start()
    {
        
    }

    public void save()
    {
        string data = JsonUtility.ToJson(nowPlayer);
        File.WriteAllText(path + nowSlot.ToString(), data);
    }

    public void load()
    {
        string data =  File.ReadAllText(path + nowSlot.ToString());
        nowPlayer = JsonUtility.FromJson<Player>(data);
    }

    public void DataClear()
    {
        nowSlot = -1;
        nowPlayer = new Player();
    }
}

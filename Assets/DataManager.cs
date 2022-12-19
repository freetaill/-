using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System;

// �����ϴ� ���
// 1. ������ �����Ͱ� ����
// 2. �����͸� ���̽����� ��ȯ
// 3. ���̽��� �ܺο� ����

// �ҷ����� ���
// 1. �ܺο� ����� ���̽��� ������
// 2. ���̽��� ������ ���·� ��ȯ
// 3. �ҷ��� �����͸� ���

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public Player nowPlayer = new Player();
    public Animal nowAnimal = new Animal(0, 10, 0, 10, 100, 0, 100, 0, 10);
    public Ranking nowranking = new Ranking();

    public Sprite[] face;
    public Sprite[] sit;
    public Sprite[] stand;

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

        path = Application.dataPath + "/save";
    }

    void Start()
    {
        
    }

    public void save()
    {
        string data = JsonUtility.ToJson(nowPlayer) + "/" + JsonUtility.ToJson(nowAnimal) + "/" 
            + JsonUtility.ToJson(nowranking);
        File.WriteAllText(path + nowSlot.ToString(), data);
    }

    public void load()
    {
        string data =  File.ReadAllText(path + nowSlot.ToString());
        string[] datasplit = data.Split('/');
        nowPlayer = JsonUtility.FromJson<Player>(datasplit[0]);
        nowAnimal = JsonUtility.FromJson<Animal>(datasplit[1]);
        nowranking = JsonUtility.FromJson<Ranking>(datasplit[2]);
    }

    public void DataClear()
    {
        nowSlot = -1;
        nowPlayer = new Player();
    }
}

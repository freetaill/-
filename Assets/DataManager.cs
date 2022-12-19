using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System;

// 저장하는 방법
// 1. 저장할 데이터가 존재
// 2. 에이터를 제이슨으로 변환
// 3. 제이슨을 외부에 저장

// 불러오는 방법
// 1. 외부에 저장된 제이슨을 가져옴
// 2. 제이슨을 데이터 형태로 변환
// 3. 불러온 데이터를 사용

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
        //싱글톤 생성
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
        //싱글톤 생성

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

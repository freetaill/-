using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 저장하는 방법
// 1. 저장할 데이터가 존재
// 2. 에이터를 제이슨으로 변환
// 3. 제이슨을 외부에 저장

// 불러오는 방법
// 1. 외부에 저장된 제이슨을 가져옴
// 2. 제이슨을 데이터 형태로 변환
// 3. 불러온 데이터를 사용

public class PlayerData
{
    public string Name;
    public int Gold;
}

public class DataManager : MonoBehaviour
{
    private static DataManager instance;

    //public static DataManager Instance
    //{
    //    get
    //    {
    //        if(instance == null)
    //        {
    //            return null;
    //        }
    //        return instance;
    //    }
    //}

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void save()
    {
        print("저장완료");
    }
}

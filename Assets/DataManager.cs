using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        print("����Ϸ�");
    }
}

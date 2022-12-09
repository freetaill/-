using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class savelordbuttoncontrol : MonoBehaviour
{
    public GameObject messagebox;
    public Text[] slotText;

    bool[] have_savefile = new bool[3];

    public void back_button()
    {
        SceneManager.LoadScene("����ȭ��");
    }
    public void new_start_button()
    {
        GoGame();
    }

    public void Slot(int number)
    {
        DataManager.instance.nowSlot = number;

        if (have_savefile[number])
        {
            // 1. ����� ������ ������
            DataManager.instance.load();
            GoGame();
        }
        else
        {
            // 2. ����� ������ ������
            Creat_saveFile();
        }
    }

    public void Creat_saveFile()
    {
        messagebox.SetActive(true);
    }

    public void GoGame()
    {
        if (!have_savefile[DataManager.instance.nowSlot])
        {
            DataManager.instance.nowPlayer.Name = "����� ���� ����";
            DataManager.instance.save();
            SceneManager.LoadScene("��������");
        }
        else
        {
            SceneManager.LoadScene("main scene");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            if (File.Exists(DataManager.instance.path + $"{i}"))
            {
                have_savefile[i] = true;
                DataManager.instance.nowSlot = i;
                DataManager.instance.load();
                slotText[i].text = DataManager.instance.nowPlayer.Name;
            }
            else
            {
                slotText[i].text = "�������";
            }
        }
        DataManager.instance.DataClear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class storebuttoncontrol : MonoBehaviour
{
    public GameObject store_Panel;
    public Text text;

    public void back_button()
    {
        SceneManager.LoadScene("main scene");
    }

    public void button1()
    {
        if(DataManager.instance.nowPlayer.Gold >= 20)
        {
            DataManager.instance.nowPlayer.Gold -= 20;
            DataManager.instance.nowPlayer.cheapfood++;
            store_Panel.SetActive(true);
            text.text = "�Ϲݻ�Ḧ ����ϴ�.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�Ϲݻ�Ḧ ������ϴ�.";
        }
    }

    public void button2()
    {
        if (DataManager.instance.nowPlayer.Gold >= 40)
        {
            DataManager.instance.nowPlayer.Gold -= 40;
            DataManager.instance.nowPlayer.nomalfood++;
            store_Panel.SetActive(true);
            text.text = "��޻�Ḧ ����ϴ�.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "��޻�Ḧ ������ϴ�.";
        }
    }

    public void button3()
    {
        if (DataManager.instance.nowPlayer.Gold >= 80)
        {
            DataManager.instance.nowPlayer.Gold -= 80;
            DataManager.instance.nowPlayer.highfood++;
            store_Panel.SetActive(true);
            text.text = "�ְ�޻�Ḧ ����ϴ�.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ְ�޻�Ḧ ������ϴ�.";
        }
    }

    public void button4()
    {
        if (DataManager.instance.nowPlayer.Gold >= 30)
        {
            DataManager.instance.nowPlayer.Gold -= 30;
            DataManager.instance.nowPlayer.chikenfood++;
            store_Panel.SetActive(true);
            text.text = "�߰���������� ����ϴ�.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�߰���������� ������ϴ�.";
        }
    }

    public void button5()
    {
        if (DataManager.instance.nowPlayer.Gold >= 30)
        {
            DataManager.instance.nowPlayer.Gold -= 30;
            DataManager.instance.nowPlayer.tunafood++;
            store_Panel.SetActive(true);
            text.text = "��ġ�������� ����ϴ�.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "��ġ�������� ������ϴ�.";
        }
    }

    public void button6()
    {
        if (DataManager.instance.nowPlayer.Gold >= 50)
        {
            DataManager.instance.nowPlayer.Gold -= 50;
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.charming += rb;
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ����ϴ�";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ������ϴ�";
        }
    }

    public void button7()
    {
        if (DataManager.instance.nowPlayer.Gold >= 50)
        {
            DataManager.instance.nowPlayer.Gold -= 50;
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.charming += rb;
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ����ϴ�";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ������ϴ�";
        }
    }

    public void button8()
    {
        if (DataManager.instance.nowPlayer.Gold >= 50)
        {
            DataManager.instance.nowPlayer.Gold -= 50;
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.charming += rb;
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ����ϴ�";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ������ϴ�";
        }
    }

    public void button9()
    {
        if (DataManager.instance.nowPlayer.Gold >= 50)
        {
            DataManager.instance.nowPlayer.Gold -= 50;
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.charming += rb;
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ����ϴ�";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ������ϴ�";
        }
    }

    public void button10()
    {
        if (DataManager.instance.nowPlayer.Gold >= 50)
        {
            DataManager.instance.nowPlayer.Gold -= 50;
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.charming += rb;
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ����ϴ�";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ������ϴ�";
        }
    }

    public void button11()
    {
        if (DataManager.instance.nowPlayer.Gold >= 50)
        {
            DataManager.instance.nowPlayer.Gold -= 50;
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.charming += rb;
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ����ϴ�";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "�ڵ� ���� ������ϴ�";
        }
    }

    public void Store_correct_button()
    {
        store_Panel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        store_Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

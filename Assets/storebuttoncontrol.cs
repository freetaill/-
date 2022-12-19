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
            text.text = "일반사료를 샀습니다.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "일반사료를 못샀습니다.";
        }
    }

    public void button2()
    {
        if (DataManager.instance.nowPlayer.Gold >= 40)
        {
            DataManager.instance.nowPlayer.Gold -= 40;
            DataManager.instance.nowPlayer.nomalfood++;
            store_Panel.SetActive(true);
            text.text = "고급사료를 샀습니다.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "고급사료를 못샀습니다.";
        }
    }

    public void button3()
    {
        if (DataManager.instance.nowPlayer.Gold >= 80)
        {
            DataManager.instance.nowPlayer.Gold -= 80;
            DataManager.instance.nowPlayer.highfood++;
            store_Panel.SetActive(true);
            text.text = "최고급사료를 샀습니다.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "최고급사료를 못샀습니다.";
        }
    }

    public void button4()
    {
        if (DataManager.instance.nowPlayer.Gold >= 30)
        {
            DataManager.instance.nowPlayer.Gold -= 30;
            DataManager.instance.nowPlayer.chikenfood++;
            store_Panel.SetActive(true);
            text.text = "닭고기통조림을 샀습니다.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "닭고기통조림을 못샀습니다.";
        }
    }

    public void button5()
    {
        if (DataManager.instance.nowPlayer.Gold >= 30)
        {
            DataManager.instance.nowPlayer.Gold -= 30;
            DataManager.instance.nowPlayer.tunafood++;
            store_Panel.SetActive(true);
            text.text = "참치통조림을 샀습니다.";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "참치통조림을 못샀습니다.";
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
            text.text = "코디 템을 샀습니다";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "코디 템을 못샀습니다";
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
            text.text = "코디 템을 샀습니다";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "코디 템을 못샀습니다";
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
            text.text = "코디 템을 샀습니다";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "코디 템을 못샀습니다";
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
            text.text = "코디 템을 샀습니다";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "코디 템을 못샀습니다";
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
            text.text = "코디 템을 샀습니다";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "코디 템을 못샀습니다";
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
            text.text = "코디 템을 샀습니다";
        }
        else
        {
            store_Panel.SetActive(true);
            text.text = "코디 템을 못샀습니다";
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

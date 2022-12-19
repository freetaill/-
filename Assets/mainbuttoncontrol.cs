using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainbuttoncontrol : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject interaction_Panel;
    public GameObject back_panel;

    public GameObject train_Panel;
    public GameObject confirm_Panel;
    public GameObject train_not_Panel;

    public GameObject parttime_Panel;
    public GameObject parttime_confirm_Panel;
    public GameObject parttime_not_Panel;

    public GameObject Interaction_inner_Panel;

    public Text confirm_text;
    public Text parttime_confirm_text;
    public Text train_not_text;
    public Text parttime_not_text;
    public Text interaction_text;

    public Slider animal_fatigue;
    public Slider player_fatigue;
    public Slider closed;
    public Text gold_text;
    public Image[] image;

    public void menu_button()
    {
        Time.timeScale = 0;
        back_panel.SetActive(true);
        menuPanel.SetActive(true);
    }
    public void menu_back_start_button()
    {
        SceneManager.LoadScene("시작화면");
    }
    public void menu_save_lord_button()
    {
        DataManager.instance.save();
    }
    public void menu_Setting_button()
    {

    }
    public void menu_back_main_button()
    {
        Time.timeScale = 1;
        back_panel.SetActive(false);
        menuPanel.SetActive(false);
    }

    public void ineraction_button()
    {
        interaction_Panel.SetActive(!interaction_Panel.active);
    }
    public void interaction_walk_button()
    {
        if (DataManager.instance.nowAnimal.fatigue >= 20 && DataManager.instance.nowPlayer.fatigue >= 20)
        {
            Interaction_inner_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.closeness += rb;
            DataManager.instance.nowPlayer.fatigue -= 20;
            DataManager.instance.nowAnimal.fatigue -= 20;
            interaction_text.text = "산책을 완료 했습니다.";
        }
        else
        {
            Interaction_inner_Panel.SetActive(true);
            interaction_text.text = "산책을 하지 못합니다.";
        }
        status_update();
    }

    public void interaction_walk_correct_button()
    {
        Interaction_inner_Panel.SetActive(false);
        interaction_Panel.SetActive(false);
    }

    public void interaction_feed_button()
    {
        status_update();
    }

    public void competition_button()
    {
        SceneManager.LoadScene("competition");
    }

    public void store_button()
    {
        SceneManager.LoadScene("Shop");
    }

    //
    // 훈련
    //
    public void training_button()
    {
        train_Panel.SetActive(true);
    }
    
    public void health_button()
    {
        if (DataManager.instance.nowAnimal.fatigue >= 20)
        {
            confirm_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.hp += rb;
            DataManager.instance.nowAnimal.fatigue -= 20;
            confirm_text.text = "체력이 " + rb.ToString() + " 만큼 올랐습니다.";
        }
        else
        {
            train_not_Panel.SetActive(true);
            train_not_text.text = "더 이상\n" + "훈련을 하지 못합니다.";
        }
        status_update();
    }

    public void jump_button()
    {
        if (DataManager.instance.nowAnimal.fatigue >= 20)
        {
            confirm_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.jump += rb;
            DataManager.instance.nowAnimal.fatigue -= 20;
            confirm_text.text = "점프력이 " + rb.ToString() + " 만큼 올랐습니다.";
        }
        else
        {
            train_not_Panel.SetActive(true);
            train_not_text.text = "더 이상\n" + "훈련을 하지 못합니다.";
        }
        status_update();
    }

    public void run_button()
    {
        if (DataManager.instance.nowAnimal.fatigue >= 20)
        {
            confirm_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            DataManager.instance.nowAnimal.speed += rb;
            DataManager.instance.nowAnimal.fatigue -= 20;
            confirm_text.text = "속도가 " + rb.ToString() + " 만큼 올랐습니다.";
        }
        else
        {
            train_not_Panel.SetActive(true);
            train_not_text.text = "더 이상\n" + "훈련을 하지 못합니다.";
        }
        status_update();
    }

    public void train_exit_button()
    {
        train_Panel.SetActive(false);
        confirm_Panel.SetActive(false);
        train_not_Panel.SetActive(false);
    }

    public void confirm_button()
    {
        confirm_Panel.SetActive(false);
        train_Panel.SetActive(false);
    }

    public void train_not()
    {
        train_not_Panel.SetActive(false);
        train_Panel.SetActive(false);
    }

    //
    // 알바
    //
    public void parttime_button()
    {
        parttime_Panel.SetActive(true);
    }

    public void easybutton()
    {
        if (DataManager.instance.nowPlayer.fatigue >= 20)
        {
            parttime_confirm_Panel.SetActive(true);
            parttime_confirm_text.text = "20원을 벌었습니다.";
            DataManager.instance.nowPlayer.Gold += 20;
            DataManager.instance.nowPlayer.fatigue -= 20;
        }
        else
        {
            parttime_not_Panel.SetActive(true);
            parttime_not_text.text = "더 이상 쉬운 알바를\n" + "하지 못합니다.";
        }
        status_update();
    }

    public void normalbutton()
    {
        if (DataManager.instance.nowPlayer.fatigue >= 50)
        {
            parttime_confirm_Panel.SetActive(true);
            parttime_confirm_text.text = "50원을 벌었습니다.";
            DataManager.instance.nowPlayer.Gold += 50;
            DataManager.instance.nowPlayer.fatigue -= 50;
        }
        else
        {
            parttime_not_Panel.SetActive(true);
            parttime_not_text.text = "더 이상 보통 알바를\n" + "하지 못합니다.";
        }
        status_update();
    }

    public void hardbutton()
    {
        if (DataManager.instance.nowPlayer.fatigue >= 100)
        {
            parttime_confirm_Panel.SetActive(true);
            parttime_confirm_text.text = "100원을 벌었습니다.";
            DataManager.instance.nowPlayer.Gold += 100;
            DataManager.instance.nowPlayer.fatigue -= 100;
        }
        else
        {
            parttime_not_Panel.SetActive(true);
            parttime_not_text.text = "더 이상 고된 알바를\n" + "하지 못합니다.";
        }
        status_update();
    }

    public void sleepbutton()
    {
        parttime_confirm_Panel.SetActive(true);
        parttime_confirm_text.text = "체력을 회복합니다";
        DataManager.instance.nowPlayer.fatigue += 100;
    }

    public void parttime_exit()
    {
        parttime_Panel.SetActive(false);
        parttime_confirm_Panel.SetActive(false);
        parttime_not_Panel.SetActive(false);
    }

    public void parttime_confirm_button()
    {
        parttime_confirm_Panel.SetActive(false);
        parttime_Panel.SetActive(false);
    }

    public void parttime_not()
    {
        parttime_not_Panel.SetActive(false);
        parttime_Panel.SetActive(false);
    }
    public void status_update()
    {
        animal_fatigue.value = DataManager.instance.nowAnimal.fatigue;
        player_fatigue.value = DataManager.instance.nowPlayer.fatigue;
        closed.value = DataManager.instance.nowAnimal.closeness;
        gold_text.text = DataManager.instance.nowPlayer.Gold.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        back_panel.SetActive(false);
        interaction_Panel.SetActive(false);
        menuPanel.SetActive(false);
        train_Panel.SetActive(false);
        confirm_Panel.SetActive(false);
        train_not_Panel.SetActive(false);
        parttime_Panel.SetActive(false);
        parttime_confirm_Panel.SetActive(false);
        parttime_not_Panel.SetActive(false);
        Interaction_inner_Panel.SetActive(false);
        status_update();
        image[0].sprite = DataManager.instance.stand[DataManager.instance.nowAnimal.type];
        image[1].sprite = DataManager.instance.face[DataManager.instance.nowAnimal.type];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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

    public Text confirm_text;
    public Text parttime_confirm_text;
    public Text train_not_text;
    public Text parttime_not_text;

    public Player player;
    public Animal myanimal;

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

    }
    public void interaction_feed_button()
    {

    }

    public void parttime_button()
    {
        parttime_Panel.SetActive(true);
    }

    public void competition_button()
    {
        SceneManager.LoadScene("competition");
    }

    public void store_button()
    {
        SceneManager.LoadScene("Shop");
    }

    public void training_button()
    {
        train_Panel.SetActive(true);
    }

    public void health_button()
    {
        if (myanimal.fatigue >= 20)
        {
            confirm_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            myanimal.hp += rb;
            myanimal.fatigue -= 20;
            confirm_text.text = "체력이 " + rb.ToString() + " 만큼 올랐습니다.";
        }
        else
        {
            train_not_Panel.SetActive(true);
            train_not_text.text = "더 이상\n" + "훈련을 하지 못합니다.";
        }
        
    }

    public void jump_button()
    {
        if (myanimal.fatigue >= 20)
        {
            confirm_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            // myanimal.jump += rb;
            myanimal.fatigue -= 20;
            confirm_text.text = "점프력이 " + rb.ToString() + " 만큼 올랐습니다.";
        }
        else
        {
            train_not_Panel.SetActive(true);
            train_not_text.text = "더 이상\n" + "훈련을 하지 못합니다.";
        }
    }

    public void run_button()
    {
        if (myanimal.fatigue >= 20)
        {
            confirm_Panel.SetActive(true);
            int rb = Random.Range(1, 3);
            myanimal.speed += rb;
            myanimal.fatigue -= 20;
            confirm_text.text = "속도가 " + rb.ToString() + " 만큼 올랐습니다.";
        }
        else
        {
            train_not_Panel.SetActive(true);
            train_not_text.text = "더 이상\n" + "훈련을 하지 못합니다.";
        }
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

    public void easybutton()
    {
        if (player.fatigue >= 20)
        {
            parttime_confirm_Panel.SetActive(true);
            parttime_confirm_text.text = "20원을 벌었습니다.";
            player.Gold += 20;
            player.fatigue -= 20;
        }
        else
        {
            parttime_not_Panel.SetActive(true);
            parttime_not_text.text = "더 이상 쉬운 알바를\n" + "하지 못합니다.";
        }
    }

    public void normalbutton()
    {
        if (player.fatigue >= 50)
        {
            parttime_confirm_Panel.SetActive(true);
            parttime_confirm_text.text = "50원을 벌었습니다.";
            player.Gold += 50;
            player.fatigue -= 50;
        }
        else
        {
            parttime_not_Panel.SetActive(true);
            parttime_not_text.text = "더 이상 보통 알바를\n" + "하지 못합니다.";
        }
    }

    public void hardbutton()
    {
        if (player.fatigue >= 100)
        {
            parttime_confirm_Panel.SetActive(true);
            parttime_confirm_text.text = "100원을 벌었습니다.";
            player.Gold += 100;
            player.fatigue -= 100;
        }
        else
        {
            parttime_not_Panel.SetActive(true);
            parttime_not_text.text = "더 이상 고된 알바를\n" + "하지 못합니다.";
        }
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
        player = new Player();
        myanimal = new Animal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

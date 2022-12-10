using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainbuttoncontrol : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject interaction_Panel;
    public GameObject back_panel;
    
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

    }

    // Start is called before the first frame update
    void Start()
    {
        back_panel.SetActive(false);
        interaction_Panel.SetActive(false);
        menuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

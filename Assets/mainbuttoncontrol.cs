using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainbuttoncontrol : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject interaction_Panel;
    
    public void menu_button()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
    }
    public void menu_back_start_button()
    {
        SceneManager.LoadScene("start scene");
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
        menuPanel.SetActive(false);
    }

    public void ineraction_button()
    {
        interaction_Panel.SetActive(true);
    }
    public void interaction_walk_button()
    {

    }
    public void interaction_feed_button()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        interaction_Panel.SetActive(false);
        menuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

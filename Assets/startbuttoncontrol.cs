using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbuttoncontrol : MonoBehaviour
{
    public void start_button()
    {
        SceneManager.LoadScene("���ν���");
    }

    public void exit_button()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

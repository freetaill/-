using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class savelordbuttoncontrol : MonoBehaviour
{
    public void back_button()
    {
        SceneManager.LoadScene("시작화면");
    }
    public void new_start_button()
    {
        SceneManager.LoadScene("동물선택");
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

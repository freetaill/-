using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class savelordbuttoncontrol : MonoBehaviour
{
    public void back_button()
    {
        SceneManager.LoadScene("����ȭ��");
    }
    public void new_start_button()
    {
        SceneManager.LoadScene("��������");
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

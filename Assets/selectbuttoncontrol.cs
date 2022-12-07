using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectbuttoncontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public void select_animal1()
    {
        SceneManager.LoadScene("main scene");
    }
    public void select_animal2()
    {
        SceneManager.LoadScene("main scene");
    }
    public void select_animal3()
    {
        SceneManager.LoadScene("main scene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

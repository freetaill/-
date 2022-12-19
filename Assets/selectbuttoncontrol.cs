using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class selectbuttoncontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public void select_animal1()
    {
        DataManager.instance.nowAnimal.type = 1;
        DataManager.instance.save();
        SceneManager.LoadScene("main scene");
    }
    public void select_animal2()
    {
        DataManager.instance.nowAnimal.type = 3;
        DataManager.instance.save();
        SceneManager.LoadScene("main scene");
    }
    public void select_animal3()
    {
        DataManager.instance.nowAnimal.type = 7;
        DataManager.instance.save();
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

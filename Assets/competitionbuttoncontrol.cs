using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class competitionbuttoncontrol : MonoBehaviour
{
    public Animal[] rival = new Animal[5];

    public void swim_button()
    {

    }

    public void charmming_button()
    {

    }

    public void hurdle_button()
    {

    }

    public void back_button()
    {
        SceneManager.LoadScene("main scene");
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

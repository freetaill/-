using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class competitionbuttoncontrol : MonoBehaviour
{
    public Image first_image;
    public Image second_image;
    public Image third_image;

    public Animal[] Rival = new Animal[5];

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

    public void show_rank()
    {

    }

    public void make_Rival()
    {
        int[] type = new int[5];
        int hp = DataManager.instance.nowAnimal.hp;
        int speed = DataManager.instance.nowAnimal.speed;
        int jump = DataManager.instance.nowAnimal.jump;

        for (int i = 0; i < 5; i++)
        {
            int num = Random.Range(1, 11);
            if(DataManager.instance.nowAnimal.type == $"dog{num}" || type.Contains(num) == true)
            {
                i--;
                continue;
            }
            else
            {
                type[i] = num;
                Rival[i].type = $"dog{type}";
                Rival[i].hp = Random.Range(hp - 10, hp + 10);
                Rival[i].speed = Random.Range(speed - 10, speed + 10);
                Rival[i].jump = Random.Range(jump - 10, jump + 10);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        make_Rival();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

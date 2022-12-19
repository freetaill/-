using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class competitionbuttoncontrol : MonoBehaviour
{
    public GameObject competition_Panel;

    public Image first_image;
    public Image second_image;
    public Image third_image;

    public Image[] racer;
    public Image[] endpoint;

    public Animal[] Rival = new Animal[5];

    public int posx;

    public void swim_button()
    {
        competition_Panel.SetActive(true);
    }

    public void charmming_button()
    {
        competition_Panel.SetActive(true);
    }

    public void hurdle_button()
    {
        competition_Panel.SetActive(true);
    }

    public void back_button()
    {
        SceneManager.LoadScene("main scene");
    }

    public void show_rank()
    {

    }

    public void move()
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
            if(DataManager.instance.nowAnimal.type == num || type.Contains(num) == true)
            {
                i--;
                continue;
            }
            else
            {
                type[i] = num;
                Rival[i] = new Animal(0, 0, 0, 0, 0, 0, 0, 0, 0);
                Rival[i].type = num;
                Rival[i].hp = Random.Range(hp - 10, hp + 10);
                Rival[i].speed = Random.Range(speed - 10, speed + 10);
                Rival[i].jump = Random.Range(jump - 10, jump + 10);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        competition_Panel.SetActive(false);
        posx = (int)racer[0].transform.position.x;
        make_Rival();
        for (int i = 0; i < 6;i++)
        {
            if (i != 0)
            {
                racer[i].sprite = DataManager.instance.stand[i];
            }
            else
            {
                racer[0].sprite = DataManager.instance.stand[DataManager.instance.nowAnimal.type];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(racer[0].transform.position == endpoint[0].transform.position)
        {
            print("µµÂø");
        }
        else
        {
            racer[0].transform.position = Vector2.MoveTowards
            (racer[0].transform.position, endpoint[0].transform.position, 40 * Time.deltaTime);
        }
    }
}

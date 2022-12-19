using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class competitionbuttoncontrol : MonoBehaviour
{
    public GameObject competition_Panel;
    public GameObject charm_Panel;
    public GameObject[] start_Button;

    public Image[] ranking;
    public Image[] racer;
    public Image[] endpoint;
    public Image[] beauty;

    public Animal[] Rival = new Animal[6];
    public bool[] flag = new bool[3];

    public float track;

    public void swim_button()
    {
        start_Button[0].SetActive(true);
        start_Button[1].SetActive(false);
        start_Button[2].SetActive(false);
        if (DataManager.instance.nowranking.swim_type[0] != DataManager.instance.nowranking.swim_type[1])
        {
            show_swimrank();
        }
    }

    public void start_swim()
    {
        competition_Panel.SetActive(true);
        reset_position();
        swimmove();
        swim_rank();
    }

    public void charmming_button()
    {
        start_Button[0].SetActive(false);
        start_Button[1].SetActive(true);
        start_Button[2].SetActive(false);
        if (DataManager.instance.nowranking.charm_type[0] != DataManager.instance.nowranking.charm_type[1])
        {
            show_charmming();
        }
    }

    public void start_charmming()
    {
        charm_Panel.SetActive(true);
        reset_position();
        charmming_rank();
    }

    public void hurdle_button()
    {
        start_Button[0].SetActive(false);
        start_Button[1].SetActive(false);
        start_Button[2].SetActive(true);
        if (DataManager.instance.nowranking.hurdle_type[0] != DataManager.instance.nowranking.hurdle_type[1])
        {
            show_hurdle();
        }
    }

    public void start_hurdle()
    {
        competition_Panel.SetActive(true);
        reset_position();
        hurdlemove();
        hurdle_rank();
    }

    public void back_button()
    {
        SceneManager.LoadScene("main scene");
    }

    async public void swim_rank()
    {
        double temp = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (DataManager.instance.nowranking.swim_hp[j] > DataManager.instance.nowranking.swim_hp[j+1])
                {
                    temp = DataManager.instance.nowranking.swim_hp[j];
                    DataManager.instance.nowranking.swim_hp[j] = DataManager.instance.nowranking.swim_hp[j+1];
                    DataManager.instance.nowranking.swim_hp[j+1] = temp;

                    temp = DataManager.instance.nowranking.swim_type[j];
                    DataManager.instance.nowranking.swim_type[j] = DataManager.instance.nowranking.swim_type[j+1];
                    DataManager.instance.nowranking.swim_type[j+1] = (int)temp;
                }
            }
        }
        flag[0] = true;
        show_swimrank();
        await Task.Delay(5000);
        competition_Panel.SetActive(false);
    }

    public void show_swimrank()
    {
        if (flag[0])
        {
            for (int i = 5; i > 2; i--)
            {
                ranking[5 - i].sprite = DataManager.instance.sit[DataManager.instance.nowranking.swim_type[i]];
            }
        }
    }

    async public void charmming_rank()
    {
        double temp = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (DataManager.instance.nowranking.charm_charmming[j]
                    > DataManager.instance.nowranking.charm_charmming[j + 1])
                {
                    temp = DataManager.instance.nowranking.charm_charmming[j];
                    DataManager.instance.nowranking.charm_charmming[j] =
                        DataManager.instance.nowranking.charm_charmming[j + 1];
                    DataManager.instance.nowranking.charm_charmming[j + 1] = temp;

                    temp = DataManager.instance.nowranking.charm_type[j];
                    DataManager.instance.nowranking.charm_type[j] = DataManager.instance.nowranking.charm_type[j + 1];
                    DataManager.instance.nowranking.charm_type[j + 1] = (int)temp;
                }
            }
        }
        flag[1] = true;
        show_charmming();
        int[] rank = new int[3];
        int k = 0;
        float time = 0;
        Vector2 originScale = beauty[0].transform.localScale;
        for(int i = 5; i >= 3; i--)
        {
            for(int j = 0; j < 6; j++)
            {
                if (Rival[j].type == DataManager.instance.nowranking.charm_type[i])
                {
                    rank[k] = j;
                    k++; break;
                }
            }
        }
        k = 0;
        for(double size = 1.7; size > 1.2; size -= 0.2)
        {
            while (beauty[rank[k]].transform.localScale.x < size)
            {
                beauty[rank[k]].transform.localScale  = originScale * (1f + time * 3f);
                time += Time.deltaTime;
                if(beauty[rank[k]].transform.localScale.x >= size) 
                { 
                    time = 0;
                    k++;
                    break;
                }
            }
        }
        await Task.Delay(5000);
        charm_Panel.SetActive(false);
    }

    public void show_charmming()
    {
        if (flag[1])
        {
            for (int i = 5; i > 2; i--)
            {
                ranking[5 - i].sprite = DataManager.instance.sit[DataManager.instance.nowranking.charm_type[i]];
            }
        }
    }

    async public void hurdle_rank()
    {
        double temp = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (DataManager.instance.nowranking.hurdle_speedjump[j] 
                    > DataManager.instance.nowranking.hurdle_speedjump[j + 1])
                {
                    temp = DataManager.instance.nowranking.hurdle_speedjump[j];
                    DataManager.instance.nowranking.hurdle_speedjump[j] = 
                        DataManager.instance.nowranking.hurdle_speedjump[j + 1];
                    DataManager.instance.nowranking.hurdle_speedjump[j + 1] = temp;

                    temp = DataManager.instance.nowranking.hurdle_type[j];
                    DataManager.instance.nowranking.hurdle_type[j] = DataManager.instance.nowranking.hurdle_type[j + 1];
                    DataManager.instance.nowranking.hurdle_type[j + 1] = (int)temp;
                }
            }
        }
        flag[2] = true;
        show_hurdle();
        await Task.Delay(5000);
        competition_Panel.SetActive(false);
    }

    public void show_hurdle()
    {
        if (flag[2])
        {
            for (int i = 5; i > 2; i--)
            {
                ranking[5 - i].sprite = DataManager.instance.sit[DataManager.instance.nowranking.hurdle_type[i]];
            }
        }
    }

    public void swimmove()
    {
        racer[0].transform.position = Vector2.MoveTowards
            (racer[0].transform.position, endpoint[0].transform.position, 
            (float)DataManager.instance.nowranking.swim_hp[0] * Time.deltaTime);
        racer[1].transform.position = Vector2.MoveTowards
            (racer[1].transform.position, endpoint[1].transform.position,
            (float)DataManager.instance.nowranking.swim_hp[1] * Time.deltaTime);
        racer[2].transform.position = Vector2.MoveTowards
            (racer[2].transform.position, endpoint[2].transform.position,
            (float)DataManager.instance.nowranking.swim_hp[2] * Time.deltaTime);
        racer[3].transform.position = Vector2.MoveTowards
            (racer[3].transform.position, endpoint[3].transform.position,
            (float)DataManager.instance.nowranking.swim_hp[3] * Time.deltaTime);
        racer[4].transform.position = Vector2.MoveTowards
            (racer[4].transform.position, endpoint[4].transform.position,
            (float)DataManager.instance.nowranking.swim_hp[4] * Time.deltaTime);
        racer[5].transform.position = Vector2.MoveTowards
            (racer[5].transform.position, endpoint[5].transform.position,
            (float)DataManager.instance.nowranking.swim_hp[5] * Time.deltaTime);
        Invoke("swimmove", 0);
    }

    public void hurdlemove()
    {
        racer[0].transform.position = Vector2.MoveTowards
            (racer[0].transform.position, endpoint[0].transform.position,
            (float)DataManager.instance.nowranking.hurdle_speedjump[0] * Time.deltaTime);
        racer[1].transform.position = Vector2.MoveTowards
            (racer[1].transform.position, endpoint[1].transform.position,
            (float)DataManager.instance.nowranking.hurdle_speedjump[1] * Time.deltaTime);
        racer[2].transform.position = Vector2.MoveTowards
            (racer[2].transform.position, endpoint[2].transform.position,
            (float)DataManager.instance.nowranking.hurdle_speedjump[2] * Time.deltaTime);
        racer[3].transform.position = Vector2.MoveTowards
            (racer[3].transform.position, endpoint[3].transform.position,
            (float)DataManager.instance.nowranking.hurdle_speedjump[3] * Time.deltaTime);
        racer[4].transform.position = Vector2.MoveTowards
            (racer[4].transform.position, endpoint[4].transform.position,
            (float)DataManager.instance.nowranking.hurdle_speedjump[4] * Time.deltaTime);
        racer[5].transform.position = Vector2.MoveTowards
            (racer[5].transform.position, endpoint[5].transform.position,
            (float)DataManager.instance.nowranking.hurdle_speedjump[5] * Time.deltaTime);
        Invoke("hurdlemove", 0);
    }

    public void make_Rival()
    {
        int[] type = {11, 11, 11, 11, 11, 11 };
        int hp = DataManager.instance.nowAnimal.hp;
        int speed = DataManager.instance.nowAnimal.speed;
        int jump = DataManager.instance.nowAnimal.jump;
        int closeness = DataManager.instance.nowAnimal.closeness;
        int charmming = DataManager.instance.nowAnimal.charming;

        Rival[0] = new Animal(0, 0, 0, 0, 0, 0, 0, 0, 0);
        Rival[0] = DataManager.instance.nowAnimal;
        for (int i = 1; i < 6; i++)
        {
            int num = Random.Range(0, 11);
            if(DataManager.instance.nowAnimal.type == num || type.Contains(num) == true)
            {
                i--;
                continue;
            }
            else
            {
                type[i] = num;
                Rival[i] = new Animal(12, 12, 12, 12, 12, 12, 12, 12, 12);
                Rival[i].type = num;
                Rival[i].hp = Random.Range((hp - 10), (hp + 10));
                Rival[i].speed = Random.Range((speed - 10), (speed + 10));
                Rival[i].jump = Random.Range((jump - 10), (jump + 10));
                Rival[i].closeness = Random.Range((closeness - 10), (closeness + 10));
                Rival[i].charming = Random.Range(0, (charmming + 10));
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (i != 0)
            {
                racer[i].sprite = DataManager.instance.stand[type[i]];
                beauty[i].sprite = DataManager.instance.stand[type[i]];
            }
            else
            {
                racer[0].sprite = DataManager.instance.stand[DataManager.instance.nowAnimal.type];
                beauty[0].sprite = DataManager.instance.stand[DataManager.instance.nowAnimal.type];
            }
            double swimhp = (double)Rival[i].hp /3;
            double hurdlespeedjump = (double)(Rival[i].speed + Rival[i].jump) / 6;
            DataManager.instance.nowranking.swim_type[i] = Rival[i].type;
            DataManager.instance.nowranking.swim_hp[i] = swimhp; 
            DataManager.instance.nowranking.hurdle_type[i] = Rival[i].type;
            DataManager.instance.nowranking.hurdle_speedjump[i] = hurdlespeedjump;
            DataManager.instance.nowranking.charm_type[i] = Rival[i].type;
            DataManager.instance.nowranking.charm_charmming[i] = Rival[i].charming;
        }
    }

    public void reset_position()
    {
        for(int i = 0; i < 6;i++)
        {
            racer[i].transform.position = new Vector3(track, racer[i].transform.position.y);
            beauty[i].transform.localScale= Vector3.one;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        competition_Panel.SetActive(false);
        charm_Panel.SetActive(false);
        track = racer[0].transform.position.x;
        make_Rival();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

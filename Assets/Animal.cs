using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    public int type = 0;
    public int hp = 10;
    public int charming = 0;
    public int speed = 10;
    public int hunger = 100;
    public int closeness = 0;
    public int fatigue = 100;
    public int age = 0;
    public int jump = 10;
    public Animal(int type, int hp, int charming, int speed, 
        int hunger, int closeness, int fatigue, int age, int jump)
    {
        this.type = type;
        this.hp = hp;
        this.charming = charming;
        this.speed = speed;
        this.hunger = hunger;
        this.closeness = closeness;
        this.fatigue = fatigue;
        this.age = age;
        this.jump = jump;
    }
}

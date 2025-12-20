using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    //Здоровье NPC
    public int healt = 15;

    //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 2,5f;

    // Start is called before the first frame update
    void Start()
    {
        //Добавление жизни NPC
        health += level;

        print(health);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

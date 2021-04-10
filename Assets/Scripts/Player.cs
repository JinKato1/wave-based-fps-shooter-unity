﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public Transform fire_position;
    public GameObject bullet;

    public Slider health_bar;
    public Text life_text;

    public int damage = 1;
    public int current_health;

    public GameObject pause_screen;

    /*
        private void Awake()
        {
            this_instance = this;
        }*/
    // Start is called before the first frame update
    void Start()
    {
        health_bar.value = current_health;
        life_text.text = "Life: " + current_health;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause_screen.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, fire_position.position, fire_position.rotation);
            }
        }
    }


    public void TakeDamage(int damage_amount)
    {
        print("taken damage");
        current_health = current_health - damage_amount;

        if (current_health <= 0)
        {
            Destroy(gameObject);
        }

        health_bar.value = current_health;
        life_text.text = "Life: " + current_health;          
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
        if (healh <= 0)
            }
    GameObject.transform.parent.gameObject.SetActive(false);
        //gameObject.SetActive(false);
        }
}
pubic void TakeDamage(int damage)
{
    health = health - damage;
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour
{

    /*
    public GameObject barrel;
    public LaserSiteControll 1zrSight; 
    public float speed;
    public float angle;


    public UFOController myUFO;
    public GameObject projectille;

    //Use this for initialization
    void Start() {
        myUFO = GetComponent<UFOController>(); 
    )    

    //Update is called once per frame
    void Update() {

            ShootProjectile();
        }
        public void ShootProjectile()

        {
            //Rotate Laser
            Vector3 dir = Input.mousePosition -
     Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            barrel.transform.roation = Quaternion.AngleAxis(angle, Vector3.forward);


            //Set laser endpoint
            dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dir.z = 0f;
            1zrSight.SetEnd(dir);
            //Toggle Laser
          //  if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Z)
             {


                1zrSight.ToggleLaser();
            }

            //Shoot projectile
            if (Input.GetMouseButtonDown(0))
            {
                dir = Input.mousePosition -

   Camera.main.WorldToScreenPoint(transform.position);
                angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;


                barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                Instantiate(projectille, transform.position, barrel.transform.rotation);
            }
        }
        */
}




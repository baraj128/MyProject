using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapons : MonoBehaviour
{
    public GameObject projectile;
    public GameObject barrel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, barrel.transform.position, barrel.transform.rotation);
        }
    }
}

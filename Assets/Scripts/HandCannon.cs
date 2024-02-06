using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCannon : MonoBehaviour
{
    [SerializeField] private GameObject cannonBall;
    [SerializeField] private Transform muzzlePoint;
    
    private bool isShooting = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Shooting functionality
            isShooting = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isShooting = false;
        }

        if (isShooting)
        {
            Debug.Log("BOOM!");
            // Start shooting cannon balls
            //InvokeRepeating(ToString(ShootCannonBall()), 1, 2);
        }
    }

    private void ShootCannonBall()
    {
        // Cannon ball spawning
        //Instantiate(cannonBall);
    }
}

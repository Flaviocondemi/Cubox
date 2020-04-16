using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform startShot;

    
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SoundManager.playSound("Fire");
            Instantiate(projectile, startShot.position, startShot.rotation);
        }
    }

    public void shot()
    {
        SoundManager.playSound("Fire");
        Instantiate(projectile, startShot.position, startShot.rotation);
    }
    


}

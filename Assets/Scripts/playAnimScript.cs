using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimScript : MonoBehaviour
{
    public GameObject missile;
    public ParticleSystem particles;

    void Update()
    {
         if(Input.GetKeyUp(KeyCode.Space))
        missile.SetActive(true);

        if(particles.IsAlive() == false)
        missile.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Sphere;
    int speed = 20;

    void Start()
    {
        
    }
     
    void Update()
    {
      if (Input.GetKey(KeyCode.P))
      {
        var clone = Instantiate(Sphere, transform.position, transform.position, transform.position);
        clone.velocity = transform.TransformDirection(0, 0, speed);

        Destroy(clone, Sphere, 0);
      }
      
    }
}

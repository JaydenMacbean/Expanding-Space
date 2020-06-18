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
      if (Input.GetKeyDown(KeyCode.P))
      {
         GameObject clone = Instantiate(Sphere, transform.position, Quaternion.identity) as GameObject;
         Rigidbody instBulletRigidBody = clone.GetComponent<Rigidbody>();
         instBulletRigidBody.AddForce(Vector3.forward * speed);
      }
      
    }
}

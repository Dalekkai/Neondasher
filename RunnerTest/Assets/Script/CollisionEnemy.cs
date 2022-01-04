using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour

{
    public ParticleSystem hit; // The reference to the particle system prefab.

     void OnCollisionEnter(Collision other) //When colliding, first instantiate a particle system to last after the cube is destroyed, then destroy both.
    {
        ParticleSystem ps = Instantiate(hit, transform.position, transform.rotation);
        Destroy(ps,2f);
        Destroy(gameObject);
    }
}

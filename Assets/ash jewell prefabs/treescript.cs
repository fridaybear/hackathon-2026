using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treescript : MonoBehaviour
{

    public GameObject tree;
    public GameObject seed;
    private Animation anim;

    public GameObject particles;
    private ParticleSystem partsys;

    void OnCollisionEnter(Collision collision)
    {
        partsys = particles.GetComponent<ParticleSystem>();

        partsys.Emit(200);

        anim = tree.GetComponent<Animation>();
        if (collision.gameObject.name == "collisionObj")
        {

            anim.Play();
            Destroy(collision.gameObject);
            Destroy(seed);

        }

    }
}

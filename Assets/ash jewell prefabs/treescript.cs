using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treescript : MonoBehaviour
{

    public GameObject tree;
    public GameObject seed;
    private Animation anim;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ran");
        anim = tree.GetComponent<Animation>();
        if (collision.gameObject.name == "collisionObj")
        {
            anim.Play();
            Destroy(collision.gameObject);
            Destroy(seed);

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTree : MonoBehaviour
{
    public GameObject tree;
    public GameObject combo_obj;
    public GameObject parent_obj;
    public GameObject output_obj;

    private GameObject obj;

    private Animation anim;

    private Vector3 position;
    void OnCollisionEnter(Collision collision)
    {
        anim = tree.GetComponent<Animation>();

        if (combo_obj.name == collision.gameObject.name && parent_obj.name != "seed")
        {
            position = parent_obj.transform.position;
            Destroy(collision.gameObject);
            Destroy(parent_obj);
            GameObject newobj = Instantiate(output_obj, position + new Vector3(0,10,0), Quaternion.identity);
            obj = newobj;
        }

        if (collision.gameObject.name == "collisionObj" && parent_obj.name == "seed")
        {
            Destroy(collision.gameObject);
            Destroy(obj);
            anim.Play();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combination_script : MonoBehaviour
{

    public GameObject combo_obj;
    public GameObject parent_obj;
    public GameObject output_obj;

    private Vector3 position;
    void OnCollisionEnter(Collision collision)
    {
        if (combo_obj.name == collision.gameObject.name)
        {
            position = parent_obj.transform.position;
            Destroy(collision.gameObject);
            Destroy(parent_obj);
            Destroy(output_obj);
            output_obj.transform.position = parent_obj.transform.position + new Vector3(0,10,0);
        }

    }

}

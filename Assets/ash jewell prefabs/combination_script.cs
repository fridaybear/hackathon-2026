using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combination_script : MonoBehaviour
{

    public GameObject combo_obj;
    public GameObject parent_obj;
    public GameObject output_obj;
    void OnCollisionEnter(Collision collision)
    {
        if (combo_obj.name == collision.gameObject.name)
        {
            Destroy(collision.gameObject);
            Destroy(parent_obj);
            GameObject newobj = Instantiate(output_obj, new Vector3(0,3,0), Quaternion.identity);
        }
    }

}

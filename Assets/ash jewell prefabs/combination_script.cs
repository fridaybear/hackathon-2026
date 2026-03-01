using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combination_script : MonoBehaviour
{

    public GameObject combo_obj;
    public GameObject parent_obj;
    public GameObject output_obj;

    public GameObject particles;
    private ParticleSystem partSys;

    private Vector3 position;
    void OnCollisionEnter(Collision collision)
    {
        partSys = particles.GetComponent<ParticleSystem>();
        
        if (combo_obj.name == collision.gameObject.name)
        {
            partSys.transform.position = parent_obj.transform.position;
            partSys.Emit(200);
            position = parent_obj.transform.position;
            Destroy(collision.gameObject);
            Destroy(parent_obj);
            output_obj.transform.position = parent_obj.transform.position + new Vector3(0,10,0);
        }

    }

}

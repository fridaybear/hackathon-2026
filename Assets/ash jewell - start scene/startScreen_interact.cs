using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScreen_interact : MonoBehaviour
{
    public bool enable=false;
    void Update()
    {
        if (enabled == true)
        {
            onButtonPress();
        }
    }

    public void onButtonPress()
    {
        SceneManager.LoadScene("Orchard");
    }

}

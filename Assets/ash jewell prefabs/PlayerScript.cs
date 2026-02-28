using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int health=4;
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("BadEnding");
        }
    }
}

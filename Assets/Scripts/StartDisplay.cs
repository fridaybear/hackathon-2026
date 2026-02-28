using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDisplay : MonoBehaviour
{
    public GameObject NameSponsor;
    public GameObject StartButton;
    

    // Update is called once per frame
    public void ShowDisplay()
    {
        NameSponsor.SetActive(true);
        StartButton.SetActive(true);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Items;

    public GameObject StartGameButton;
    public GameObject TutButton;


    void OnEnable()
    {
        Items.SetActive(true);
        StartCoroutine(ButtonShow());
        
    }

private IEnumerator ButtonShow()
    {
        TutButton.SetActive(false);
        for (int i = 0; i < 5; i++)
        {     
            yield return new WaitForSeconds(1);
            
            
        
        }
        StartGameButton.SetActive(true);

    
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialButtonShow : MonoBehaviour
{
    public GameObject TutorialButton;
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(Wait());
        
    }


    private IEnumerator Wait()
    {
        for (int i = 0; i < 5; i++)
        {     
            yield return new WaitForSeconds(1);
            
            
        
        }
        TutorialButton.SetActive(true);
    
    }
}

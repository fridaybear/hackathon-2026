using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartMenu : MonoBehaviour
{
    
    public GameObject NameSponsor;
    private string dialogueLines = "Following Challenge By: ";
    public TextMeshProUGUI textComponent;
     private float typingSpeedSet = 0.15f;


    public GameObject StartButton;

    public GameObject LOGO;
    

    public AudioClip clip;
    private AudioSource audioSource;

   
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void ShowDisplay()
    {
        NameSponsor.SetActive(true);
        StartButton.SetActive(false);
        textComponent.text = "";

        
        


        StartCoroutine(PrintNumbers());



    }

    private IEnumerator PrintNumbers()
    {
        for (int i = 0; i < dialogueLines.Length; i++)
        {
            textComponent.text += dialogueLines[i];       
            yield return new WaitForSeconds(typingSpeedSet);
            
            
        
        }
        showLogo();
    
    }





        
    

    public void showLogo()
    {
        LOGO.SetActive(true);
        
    }


public void TutorialText()
    {
        textComponent.text = " Destroy everything... ";
    }
}

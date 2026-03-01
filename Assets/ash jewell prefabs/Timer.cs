using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Countdown;
    public float delay;
    public GameObject Player;
    public TextMeshProUGUI text;
    public string nextScene;
    private PlayerScript player_script;

    public GameObject seed;

    public GameObject particles;

    public GameObject TikTok;

    void OnEnable()
    {
        player_script = Player.GetComponent<PlayerScript>();
        Debug.Log("countdown started");
        TikTok.SetActive(true);
    }
    void Update()
    {
        particles.transform.position = seed.transform.position;

        if (Countdown > 0)
        {
            text.text = Countdown.ToString("F1");
            Debug.Log(Countdown);
            Countdown -= Time.deltaTime;
        }
        else
        {
            if (delay > 0)
            {
                text.text = "you failed";
                delay -= Time.deltaTime;    
            } else
            {
                Debug.Log("you failed to escape it");
                player_script.health -= 1;
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}

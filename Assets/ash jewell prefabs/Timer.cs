using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Countdown;
    public GameObject Player;
    public TextMeshProUGUI text;
    public string nextScene;
    private PlayerScript player_script;

    void OnEnable()
    {
        player_script = Player.GetComponent<PlayerScript>();
        Debug.Log("countdown started");
    }
    void Update()
    {
        if (Countdown > 0)
        {
            text.text = Countdown.ToString("F1");
            Debug.Log(Countdown);
            Countdown -= Time.deltaTime;
        }
        else
        {
            text.text = "you failed";
            Debug.Log("you failed to escape it");
            player_script.health -= 1;
            SceneManager.LoadScene(nextScene);
        }
    }
}

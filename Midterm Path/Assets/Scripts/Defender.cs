using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Defender : MonoBehaviour
{

    public AudioSource smash;
    public Text timerText;
    public Text healthText;
    public Text loseText;
    public int health;

    static public float seconds;
    static public float minutes;

    // Use this for initialization
    void Start()
    {
        health = 5;
        healthText.text = "Health: " + health.ToString();
        smash = GetComponent<AudioSource>();
    }

    void Update()
    {
        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    void OnCollisionStay(Collision col)
    {

        if (col.gameObject.tag == "Attacker")
        {
            smash.Play();
            health = health - 1;
            healthText.text = "Health: " + health.ToString();

            if (health == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}

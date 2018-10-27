using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour {

    public Text countText;
    public Text healthText;
    public Text loseText;
    public int count;
    public int health;

    // Use this for initialization
    void Start () {

        count = 0;
        health = 10;
        countText.text = "Score: " + count.ToString();
        healthText.text = "Health: " + health.ToString();
    }

    public void setCountText()
    {
        print("working?");
         count = count + 1;
         countText.text = "Score: " + count.ToString();

    }
}

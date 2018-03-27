using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlHealthBar : MonoBehaviour {

    public float originalHealth, currentHealth;

	// Use this for initialization
	void Start () {
        	
	}
	
	// Update is called once per frame
	void Update () {
        originalHealth = GameObject.FindObjectOfType<Cutscene>().GetComponent<Cutscene>().OriHealth;
        currentHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
        UpdateHealthBar();
	}

    void UpdateHealthBar()
    {
        GetComponent<Text>().text = ("Your Health: " + "\n" + currentHealth.ToString() + "/" + originalHealth.ToString());
    }
}

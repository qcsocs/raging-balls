using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour {
    public static int currentlySelectedCountry;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectCountry(int country)
    {
        currentlySelectedCountry = country;
    }

    public void backtoSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

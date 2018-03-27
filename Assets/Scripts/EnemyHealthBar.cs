using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject obj;
    public float originalEnemyHealth, currentEnemyHealth;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        originalEnemyHealth = obj.GetComponent<Cutscene>().oriEnemyHealth;
        currentEnemyHealth = obj.GetComponent<Cutscene>().totalHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        GetComponent<Text>().text = ("EnemyHealth:" + "\n" + currentEnemyHealth.ToString() + "/" + originalEnemyHealth.ToString());
    }
}

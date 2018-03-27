using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour {
    public SceneManage sceneManage;
    public static bool cutscene;
    Image imageComponent;
    public Sprite Poland;
    public Sprite China;
    public Sprite SouthKorea;
    public Sprite America;
    public Sprite Canada;
    public Sprite Britain;
    public Sprite SouthAfrica;
    public Sprite Germany;
    public Sprite Soviet;

    public GameObject startbutton, backButton;

    public GameObject Polandball;
    public GameObject Chinaball;
    public GameObject SouthKoreaball;
    public GameObject Americaball;
    public GameObject Canadaball;
    public GameObject Britainball;
    public GameObject SouthAfricaball;
    public GameObject Germanyball;
    public GameObject SovietUnionball;

    public GameObject Sovietball;
    public GameObject Facebookball;
    public GameObject Nkball;
    public GameObject ISISball;
    public GameObject Fire;
    public GameObject Naziball;
    public GameObject Italyball;
    public GameObject USball;
    public GameObject WinterNaziball;

    public GameObject newBall, Enemy, Enemy2, Enemy3;

    public GameObject win, lose, healthBar, enemyhealthBar;
    public float OriHealth, EnemyHealth, Enemy2Health, Enemy3Health, totalHealth, oriEnemyHealth;

    public int enemycount;

    // Use this for initialization
    void Start () {
        healthBar.SetActive(false);
        enemyhealthBar.SetActive(false);
        cutscene = true;
        imageComponent = GetComponent<Image>();
        setImage();
        
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Enemy == null && Enemy2 == null && Enemy3 == null && cutscene == false)
        {
            win.SetActive(true);
        } 

        if (newBall == null && cutscene == false)
        {
            lose.SetActive(true);
        }

        if (newBall.GetComponent<Ball>().health <= 0)
        {
            Destroy(newBall);
        }

        if (enemycount == 1)
        {
            totalHealth = EnemyHealth;
        }
        else if (enemycount == 2)
        {
            totalHealth = EnemyHealth + Enemy2Health;
        }
        else if (enemycount == 3)
        { 
            totalHealth = EnemyHealth + Enemy2Health + Enemy3Health;
        }
    }

    public void setImage()
    {
        if (SceneManage.currentlySelectedCountry == 0)
        {
            imageComponent.sprite = Poland;
        }   
        else if (SceneManage.currentlySelectedCountry == 1)
        {
            imageComponent.sprite = China;
        }
        else if (SceneManage.currentlySelectedCountry == 2)
        {
            imageComponent.sprite = SouthKorea;
        }
        else if (SceneManage.currentlySelectedCountry == 3)
        {
            imageComponent.sprite = America;
        }
        else if (SceneManage.currentlySelectedCountry == 4)
        {
            imageComponent.sprite = Canada;
        }
        else if (SceneManage.currentlySelectedCountry == 5)
        {
            imageComponent.sprite = Britain;
        }
        else if (SceneManage.currentlySelectedCountry == 6)
        {
            imageComponent.sprite = SouthAfrica;
        }
        else if (SceneManage.currentlySelectedCountry == 7)
        {
            imageComponent.sprite = Germany;
        }
        else if (SceneManage.currentlySelectedCountry == 8)
        {
            imageComponent.sprite = Soviet;
        }
    } 

    public void hideUI ()
    {
        imageComponent.enabled = false;
        startbutton.SetActive(false);
        backButton.SetActive(false);
        cutscene = false;
    }

    public void startGame()
    {
        healthBar.SetActive(true);
        enemyhealthBar.SetActive(true);

        if (SceneManage.currentlySelectedCountry == 0)
        {
            newBall = Instantiate(Polandball);
            Enemy = Instantiate(Sovietball);
            Enemy2 = Instantiate(Sovietball);
            Enemy3 = Instantiate(Sovietball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(-3f, 0.5f, 0);
            Enemy2.transform.position = new Vector3(5f, 1.4f, 0);
            Enemy3.transform.position = new Vector3(5f, -1.4f, 0);
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 1)
        {
            newBall = Instantiate(Chinaball);
            Enemy = Instantiate(Facebookball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            oriEnemyHealth = EnemyHealth;
            enemycount = 1;
        }
        else if (SceneManage.currentlySelectedCountry == 2)
        {
            newBall = Instantiate(SouthKoreaball);
            Enemy = Instantiate(Nkball);
            Enemy2 = Instantiate(Nkball);
            Enemy3 = Instantiate(Nkball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(3.96f, 2.07f, 0);
            Enemy2.transform.position = new Vector3(-7.03f, 2.74f, 0);
            Enemy3.transform.position = new Vector3(-2.46f, -2.16f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 3)
        {
            newBall = Instantiate(Americaball);
            Enemy = Instantiate(ISISball);
            Enemy2 = Instantiate(ISISball);
            Enemy3 = Instantiate(ISISball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(6.29f, -0.06f, 0);
            Enemy2.transform.position = new Vector3(0.26f, 0.1f, 0);
            Enemy3.transform.position = new Vector3(-4.11f, -4.27f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 4)
        {
            newBall = Instantiate(Canadaball);
            Enemy = Instantiate(Fire);
            Enemy2 = Instantiate(Fire);
            Enemy3 = Instantiate(Fire);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(-1.313f, 0.0562f, 0);
            Enemy2.transform.position = new Vector3(1.7982f, 0.0562f, 0);
            Enemy3.transform.position = new Vector3(4.6732f, 0.0562f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 5)
        {
            newBall = Instantiate(Britainball);
            Enemy = Instantiate(Naziball);
            Enemy2 = Instantiate(Naziball);
            Enemy3 = Instantiate(Naziball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(-4.92f, 2.71f, 0);
            Enemy2.transform.position = new Vector3(1.43f, 2.9f, 0);
            Enemy3.transform.position = new Vector3(6.06f, -1.59f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 6)
        {
            newBall = Instantiate(SouthAfricaball);
            Enemy = Instantiate(Italyball);
            Enemy2 = Instantiate(Italyball);
            Enemy3 = Instantiate(Italyball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(-1.313f, 0.0562f, 0);
            Enemy2.transform.position = new Vector3(1.113f, 0.0562f, 0);
            Enemy3.transform.position = new Vector3(7.378f, 2.035f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 7)
        {
            newBall = Instantiate(Germanyball);
            Enemy = Instantiate(USball);
            Enemy2 = Instantiate(USball);
            Enemy3 = Instantiate(USball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(-4.28f, 1.8f, 0);
            Enemy2.transform.position = new Vector3(0.171f, -0.239f, 0);
            Enemy3.transform.position = new Vector3(4.016f, -3.426f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
        else if (SceneManage.currentlySelectedCountry == 8)
        {
            newBall = Instantiate(SovietUnionball);
            Enemy = Instantiate(WinterNaziball);
            Enemy2 = Instantiate(WinterNaziball);
            Enemy3 = Instantiate(WinterNaziball);
            OriHealth = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().health;
            EnemyHealth = Enemy.GetComponent<Enemy>().health;
            Enemy2Health = Enemy2.GetComponent<Enemy>().health;
            Enemy3Health = Enemy3.GetComponent<Enemy>().health;
            newBall.transform.position = new Vector3(-7f, 0.5f, 0f);
            Enemy.transform.position = new Vector3(0.06f, 2.33f, 0);
            Enemy2.transform.position = new Vector3(0.188f, -3.116f, 0);
            Enemy3.transform.position = new Vector3(3.53f, -0.07f, 0);
            oriEnemyHealth = EnemyHealth + Enemy2Health + Enemy3Health;
            enemycount = 3;
        }
    }

        

    }


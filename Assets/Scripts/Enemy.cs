using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health, attackdmg, speed, timer;
    public Vector3 enemyPos,playerPos;
    public GameObject bullet;
    public bool haveAttackedThisTurn, firstTurn;
    public GameObject newBullet;
    public bool alive;

	// Use this for initialization
	void Start () {
        haveAttackedThisTurn = true;
        firstTurn = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (haveAttackedThisTurn == false && Ball.Enemyattack == true && firstTurn == false)
        {
            attack();
            haveAttackedThisTurn = true;
        }
        if (Ball.Enemyattack == false)
        {
            firstTurn = false;
            haveAttackedThisTurn = false;
        }

        if (health >= 0)
        {
            alive = true;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            alive = false;
            GameObject.FindObjectOfType<Cutscene>().GetComponent<Cutscene>().enemycount = GameObject.FindObjectOfType<Cutscene>().GetComponent<Cutscene>().enemycount - 1;
        }

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health = health - collision.gameObject.GetComponent<Ball>().damage; 
    }

    public void attack()
    {
        enemyPos = transform.position;
        playerPos = GameObject.FindObjectOfType<Ball>().GetComponent<Ball>().ballStaticPos;
        newBullet=Instantiate(bullet);
        newBullet.GetComponent<Bullet>().attack = attackdmg;
        newBullet.GetComponent<SpriteRenderer>().sprite = GetComponent<SpriteRenderer>().sprite;
        newBullet.transform.position = transform.position;
        newBullet.GetComponent<Rigidbody2D>().velocity = (playerPos - enemyPos) * speed;
        Invoke("killBullet", 2);

    }

    public void killBullet()
    {
        Destroy(newBullet);
    }

}


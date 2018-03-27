using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Sprite bulletSprite;
    public float attack;

    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerBall")
        {
            collision.gameObject.GetComponent<Ball>().health = collision.gameObject.GetComponent<Ball>().health - attack;
        }

        if (!collision.gameObject.GetComponent<Enemy>())
        {
            Destroy(gameObject);
        }
    }
}

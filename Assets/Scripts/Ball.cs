using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float health, speed, damage,friction,x,slow,angle;
    public Vector3 initialPos, finalPos,realTimePos, actualSpeed,ballStaticPos;
    public GameObject arrow,theArrowYouReControllingMow;
    public static bool  Enemyattack;
    public bool signal;// Use this for initialization
    private void Awake()
    {
        Enemyattack = false;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GetComponent<Rigidbody2D>().velocity.x == 0 && GetComponent<Rigidbody2D>().velocity.y == 0 && GameObject.FindObjectOfType<Bullet>() == null)
        {

            mouseDetection();
            ballStaticPos = transform.position;
            if (signal==true)
            {
                Enemyattack = true;
                signal = false;
            }
        }
        else
        {
            signal
                = true;
            x += Time.deltaTime * friction;
            x = Mathf.Clamp(x, 0, 1f);
            slow = 1 - x;
            slowDown();
        }
        print(Mathf.Pow(GetComponent<Rigidbody2D>().velocity.x, 2) + Mathf.Pow(GetComponent<Rigidbody2D>().velocity.y, 2));

        if ((Mathf.Pow(GetComponent<Rigidbody2D>().velocity.x, 2) + Mathf.Pow(GetComponent<Rigidbody2D>().velocity.y, 2) < 0.1))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
        
    }

    void GetMousePos(int a)
    {
        Vector3 mPos;
        mPos=Input.mousePosition;
        mPos.z = 0;
        mPos=Camera.main.ScreenToWorldPoint(mPos);
        if (a == 0)
        {
            initialPos = mPos;
        }
        else if (a == 1)
        {
            finalPos = mPos;
        }
        else
        {
            realTimePos = mPos;
        }
    }

    public void ballMovement()
    {

        actualSpeed =  (initialPos - finalPos)*speed;
        GetComponent<Rigidbody2D>().velocity = actualSpeed;



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x * slow, GetComponent<Rigidbody2D>().velocity.y * slow);
    }

    public void mouseDetection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Enemyattack = false;
            GetMousePos(0);
            theArrowYouReControllingMow = Instantiate(arrow);
            theArrowYouReControllingMow.transform.position = new Vector3(GetComponent<Rigidbody2D>().transform.position.x, GetComponent<Rigidbody2D>().transform.position.y, 0);

        }
        if (Input.GetMouseButton(0))
        {
            Enemyattack = false;
            GetMousePos(2);
            arrowRotation();
            arrowSize();
        }
        if (Input.GetMouseButtonUp(0))
        {
            x = 0;
            GetMousePos(1);
            ballMovement();
            Destroy(theArrowYouReControllingMow);
        }
    }

    public void slowDown()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x * slow, GetComponent<Rigidbody2D>().velocity.y * slow);
    }

    public void arrowRotation()
    {
        angle = Mathf.Atan2(-(initialPos.x - realTimePos.x) , (initialPos.y - realTimePos.y));
        theArrowYouReControllingMow.transform.rotation = Quaternion.Euler(0, 0, (angle + 3.14159265359f/2)* 57.2957795f);
    }

    public void arrowSize()
    {
        theArrowYouReControllingMow.transform.localScale = new Vector3((Mathf.Abs((initialPos.x - realTimePos.x))+Mathf.Abs(initialPos.y-realTimePos.y))*0.05f,0.3f,1);
    }
}

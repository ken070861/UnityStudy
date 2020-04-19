using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtro : MonoBehaviour
{

    public GameObject player01;
    public float speed;
    public float angSpeed;
    public static int playeratting;
    public Transform playerRightHandBone;

    // Use this for initialization
    void Start()
    {
    Transform weaponTrans = Instantiate(Resources.Load<Transform>("Weapons/Sword1"));

    weaponTrans.parent = playerRightHandBone;
    weaponTrans.localPosition = new Vector3(-0.0027f, 0.0025f, 0.0007f);
    weaponTrans.localRotation = Quaternion.Euler (new Vector3(0, -90, 90));
    weaponTrans.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {

        playerMove();
        ani();

    }

    void playerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //if (playeratting == 0)
           // {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                player01.GetComponent<Animator>().SetBool("walk", true);
            //}
        }

        if (Input.GetKey(KeyCode.S))
        {
           // if (playeratting == 0)
            //{
                transform.Translate(Vector3.forward * Time.deltaTime * -speed);
                player01.GetComponent<Animator>().SetBool("walk", true);
           // }
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(new Vector3(0f, -angSpeed, 0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(new Vector3(0f, angSpeed, 0f));
        }

        if (Input.GetButtonDown("Fire1"))
        {
            player01.GetComponent<Animator>().SetBool("att", true);
           // playeratting = 1;
        }
        else
        {
            player01.GetComponent<Animator>().SetBool("att", false);
			//attend ();
        }
    }

    void ani()
    {
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            player01.GetComponent<Animator>().SetBool("walk", false);
        }
    }

   // void attend()
    //{
    //    playeratting = 0;
  //  }


   


}

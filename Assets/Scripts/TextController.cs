using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextController : MonoBehaviour
{
    private TextManager textManager;

    void Start()
    {
        textManager = GameObject.Find("Canvas").GetComponent<TextManager>();

    }
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Robot_Torso")
        {
            textManager.rightUpdate = 1;
            //textManager.rightArmDetached.enabled = true;
            Debug.Log(textManager.rightUpdate);

        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }
}

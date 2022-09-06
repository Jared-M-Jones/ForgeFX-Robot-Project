using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text rightArm;
    public Text rightArmAttached;
    public Text rightArmDetached;

    public Text leftArm;
    public Text leftArmAttached;
    public Text leftArmDetached;

    public int rightUpdate = 0;
    public int leftUpdate = 0;
    //public TMP_Text rArm;
    //public int texts = 0;
    //private int textLast;
    //public TMP_Text rAttached;
    //public TMP_Text rDetached;

    // Start is called before the first frame update
    void Start()
    {
        rightArm.text = "Right Arm: ";
        rightArmAttached.text = "Attached";
        rightArmAttached.color = Color.green;
        rightArmDetached.text = "Dettached";
        rightArmDetached.color = Color.red;
        rightArmDetached.enabled = false;

        leftArm.text = "Left Arm: ";
        leftArmAttached.text = "Attached";
        leftArmAttached.color = Color.green;
        leftArmDetached.text = "Dettached";
        leftArmDetached.color = Color.red;
        leftArmDetached.enabled = false;
        //rAttached.text = "Attached";
        // rDetached.text = "Dettached";
        // rDetached.GameObject.setActive(false);
        //rArm.text = "Right Arm: ";


    }

    // Update is called once per frame
    void Update()
    {
        if(rightUpdate != 0)
        {
            rightArmAttached.enabled = false;
            rightArmDetached.enabled = true;
            Debug.Log(rightUpdate);
        }
    }
}

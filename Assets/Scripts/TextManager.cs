using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    // Start is called before the first frame update
    void Start()
    {
        rightArm.text = "Right Arm: ";
        rightArmAttached.text = "Attached";
        rightArmAttached.color = Color.green;
        rightArmDetached.text = "Detached";
        rightArmDetached.color = Color.red;
        rightArmDetached.enabled = false;

        leftArm.text = "Left Arm: ";
        leftArmAttached.text = "Attached";
        leftArmAttached.color = Color.green;
        leftArmDetached.text = "Detached";
        leftArmDetached.color = Color.red;
        leftArmDetached.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckUpdate();
    }

    private void CheckUpdate()
    {
        if (rightUpdate == 0)
        {
            rightArmAttached.enabled = true;
            rightArmDetached.enabled = false;
        }
        else
        {
            rightArmAttached.enabled = false;
            rightArmDetached.enabled = true;
        }

        if (leftUpdate != 0)
        {
            leftArmAttached.enabled = false;
            leftArmDetached.enabled = true;
        }
        else
        {
            leftArmAttached.enabled = true;
            leftArmDetached.enabled = false;
        }
    }
}

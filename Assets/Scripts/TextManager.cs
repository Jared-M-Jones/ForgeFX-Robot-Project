using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// creates the text for the right/left arm attached/detached
// changes text based on if the limbs are attached/detached

public class TextManager : MonoBehaviour
{
    [SerializeField]
    private Text rightArm, rightArmAttached, rightArmDetached;

    [SerializeField]
    private Text leftArm, leftArmAttached, leftArmDetached;

    public int rightUpdate = 0;

    public int leftUpdate = 0;

    // Start is called before the first frame update
    private void Start()
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
    private void Update()
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

        if (leftUpdate == 0)
        {
            leftArmAttached.enabled = true;
            leftArmDetached.enabled = false;
        }
        else
        {
            leftArmAttached.enabled = false;
            leftArmDetached.enabled = true;
        }
    }
}

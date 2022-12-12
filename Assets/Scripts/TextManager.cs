using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private LimbScript _limbScript;

    [SerializeField] private Text _arms;
    [SerializeField] private Text _rightArm;
    [SerializeField] private Text _leftArm;

    [SerializeField] private Color _attachedColor = Color.green;
    [SerializeField] private Color _detachedColor = Color.red;

    private string _attachedString = "Attached";
    private string _detachedString = "Detached";

    private void OnEnable()
    {
        if (_limbScript.RightArmAttached == true)
        {
            _rightArm.text = _attachedString;
            _rightArm.color = _attachedColor;
        }
        else
        {
            _rightArm.text = _detachedString;
            _rightArm.color = _detachedColor;
        }

        if (_limbScript.LeftArmAttached == true)
        {
            _leftArm.text = _attachedString;
            _leftArm.color = _attachedColor;
        }
        else
        {
            _leftArm.text = _detachedString;
            _leftArm.color = _detachedColor;
        }
    }

}

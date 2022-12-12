using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

// check to see if all highlight colors of the robot are set to red

public class HighlightTest
{
    [Test]
    public void Highlight_Test()
    {
        // Arrange
        int errorCounter = 0;

        Color HighlightColor = Color.red;

        HighlightArray[] hColors = GameObject.Find("Robot_Torso").GetComponentsInChildren<HighlightArray>();

        // Act
        foreach (HighlightArray colors in hColors)
        {
            if (colors._highlightColor != HighlightColor)
            {
                errorCounter++;
            }
        }

        // Assert
        Assert.IsTrue(errorCounter == 0);
    }
}

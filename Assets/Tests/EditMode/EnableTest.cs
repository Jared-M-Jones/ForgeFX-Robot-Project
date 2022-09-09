using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// check to see if all parts of the robot are enabled

public class EnableTest
{
    [Test]
    public void Enable_Test()
    {
        // Arrange
        int errorCounter = 0;

        Transform[] transform = GameObject.Find("Robot_Toy").GetComponentsInChildren<Transform>();

        // Act
        foreach (Transform child in transform)
        {
            if (!child.gameObject.activeSelf)
                errorCounter++;
        }

        // Assert
        Assert.IsTrue(errorCounter == 0);
    }
}

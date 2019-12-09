using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject nameField;

    public void TurnOnLeftRightButtons() {
        LeftButton.SetActive(true);
        RightButton.SetActive(true);
        nameField.SetActive(false);
    }
}

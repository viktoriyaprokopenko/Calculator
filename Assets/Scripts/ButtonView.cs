using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public TMP_Text Display;
    public Button ThisButton;
    public Image Background;

    public void Hide()
    {
        Display.gameObject.SetActive(false);
        ThisButton.interactable = false;
        Background.enabled = false;
    }
}
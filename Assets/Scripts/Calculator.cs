using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public TMP_Text Display;
    public Transform ParentButtons;
    public ButtonView Prefab;

    private string[] _textViews = new string[] {
        "", "", "", "<-", 
        "1", "2", "3", "+",
        "4", "5", "6", "-",
        "7", "8", "9", "/",
        ".", "0", "=", "x"};
    private string _firstDigit;
    private string _secondDigit;
    private string _current;

    private void Start()
    {
        foreach (var item in _textViews)
        {
            ButtonView btn = Instantiate(Prefab, ParentButtons);
            btn.name = item;

            if (item.Equals(""))
            {
                btn.Hide();
            }
            else
            {
                btn.Display.text = item;
                btn.ThisButton.onClick.AddListener(() => AddText(item));
            }
        }
    }

    private void CheckButton(string id)
    {
        if (id.Equals("<-"))
        {

        }
        else if (id.Equals("+"))
        {

        }
        else if (id.Equals("-"))
        {

        }
        else if (id.Equals("/"))
        {

        }
        else if (id.Equals("x"))
        {

        }
        else if (id.Equals("="))
        {

        }
        else if (id.Equals("."))
        {

        }
        else
        {

        }
    }

    public void AddText(string text)
    {
        Display.text += text;
    }
}

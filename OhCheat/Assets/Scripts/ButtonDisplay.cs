using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisplay : MonoBehaviour
{
    [Serializable]
    public struct ButtonToKey
    {
        public KeyCode keyCode;
        public Button button;
    }

    public ButtonToKey[] buttons;
    public Color onColor = Color.red;
    public Color offColor = Color.white;

    public void DisplayCurrentButton(KeyCode keycode)
    {
        foreach (var button in buttons) {
            if (button.keyCode == keycode) {
                button.button.image.color = onColor;
            }
            else {
                button.button.image.color = offColor;
            }
        }
    }
}

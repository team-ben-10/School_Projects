using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// Main Keypad class.
/// </summary>
public class Keypad : MonoBehaviour
{
    /// <summary>
    /// The main instance of the Keypad object. Only 1 Keypad per Scene possible.
    /// </summary>
    public static Keypad instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public delegate void OnClick(int value);
    OnClick onClick;

    /// <summary>
    /// Class for the List.
    /// </summary>
    [System.Serializable]
    public class PrefabButton
    {
        public string display;
        public int value;
        public PrefabButton(string display, int value)
        {
            this.display = display;
            this.value = value;
        }
    }
    [SerializeField]
    private GameObject buttonPrefab;
    [SerializeField]
    private int ButtonsPerRow;
    [SerializeField]
    private RectOffset PaddingBetweenButtons;
    [SerializeField]
    private Vector2 ButtonSize;
    [SerializeField]
    private Vector2 Spacing;
    [SerializeField]
    private List<PrefabButton> buttons = new List<PrefabButton>();

    /// <summary>
    /// Generates all buttons from the buttons List.
    /// Sets the Gameobject name to "Keypad_BTN_" + the buttons display name.
    /// Sets the buttons Display text to the coresponding display name.
    /// </summary>
    private void Start()
    {
        
        GridLayoutGroup layout = gameObject.AddComponent<GridLayoutGroup>();
        layout.padding = PaddingBetweenButtons;
        layout.cellSize = ButtonSize;
        layout.spacing = Spacing;
        layout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        layout.constraintCount = ButtonsPerRow;
        layout.childAlignment = TextAnchor.MiddleCenter;
        foreach (var item in buttons)
        {
            GameObject prefab = Instantiate(buttonPrefab, transform);
            var button = prefab.GetComponent<Button>();
            var KeyPad_BTN = prefab.GetComponent<KeypadBTN>();
            KeyPad_BTN.value = item.value;
            var Btntext = prefab.GetComponentInChildren<TMPro.TextMeshProUGUI>();
            Btntext.text = item.display.ToString();
            button.name = "Keypad_BTN_" + item.display;
            KeyPad_BTN.Click = Click;
        }
    }

    /// <summary>
    /// Adds the Parameter method to the Keypad.
    /// The method gets called every time a button from the Keypad is pressed.
    /// The method takes an integer as a paramter which is the buttons value.
    /// Normally the return button sends back a -1.
    /// </summary>
    /// <param name="method"></param>
    public void OnButtonClick(OnClick method)
    {
        onClick += method;
    }

    private void Click(int i)
    {
        onClick?.Invoke(i);
    }
}

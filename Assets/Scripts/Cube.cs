using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : Shape
{
    [SerializeField] private TMP_Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        SetVariables();
        SetColor();
    }

    // INHERITANCE
    override protected void DisplayText() {
        displayText.text = ShapeName + ": A not so great shape!";
    }

    // INHERITANCE
    override protected void SetVariables() {
        ShapeName = "Cube";
        ShapeColor = Color.red;
    }
}

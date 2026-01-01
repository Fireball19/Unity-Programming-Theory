using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cylinder : Shape
{
    [SerializeField] private TMP_Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        SetVariables();
        SetColor();
    }

    override protected void DisplayText() {
        displayText.text = ShapeName + ": A cylinder is very beautiful!";
    }

    override protected void SetVariables() {
        ShapeName = "Cylinder";
        ShapeColor = Color.green;
    }
}

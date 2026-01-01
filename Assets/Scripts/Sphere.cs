using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sphere : Shape
{
    [SerializeField] private TMP_Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        SetVariables();
        SetColor();
    }

    override protected void DisplayText() {
        displayText.text = ShapeName + ": A great shape!";
    }

    override protected void SetVariables() {
        ShapeName = "Sphere";
        ShapeColor = Color.blue;
    }
}

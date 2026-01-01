using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    public Color ShapeColor { get; set; }
    public string ShapeName { get; set; }

    protected abstract void DisplayText();

    protected abstract void SetVariables();

    protected void OnMouseDown() {
        DisplayText();
    }

    protected void SetColor() {
        gameObject.GetComponent<MeshRenderer>().material.color = ShapeColor;
    }
}

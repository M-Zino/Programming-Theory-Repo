using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    public Cylinder()
    {
        base.Color = Color.black;
    }

    // POLYMORPHISM
    public override string DisplayText()
    {
        return "Hello I am a Cylinder";
    }

    private void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", base.Color);
    }
}

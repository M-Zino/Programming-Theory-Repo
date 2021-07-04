using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    public Sphere()
    {
        base.Color = Color.yellow;
    }

    // POLYMORPHISM
    public override string DisplayText()
    {
        return "Hello I am a Sphere";
    }

    private void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", base.Color);
    }
}

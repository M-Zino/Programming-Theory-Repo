using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    public Cube()
    {
        base.Color = Color.red;
        base.Name = "Cube";
    }

    // POLYMORPHISM
    public override string DisplayText()
    {
        return $"Hello I am a {base.Name}";
    }

    private void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", base.Color);
    }
}

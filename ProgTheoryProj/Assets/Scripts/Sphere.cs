using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public Sphere()
    {
        base.Color = Color.yellow;
    }

    public override string DisplayText()
    {
        return "Hello I am a Sphere";
    }

    private void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", base.Color);
    }
}

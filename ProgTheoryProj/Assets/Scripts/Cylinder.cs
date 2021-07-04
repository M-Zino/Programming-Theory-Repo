using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public Cylinder()
    {
        base.Color = Color.black;
    }

    public override string DisplayText()
    {
        return "Hello I am a Cylinder";
    }

    private void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", base.Color);
    }
}

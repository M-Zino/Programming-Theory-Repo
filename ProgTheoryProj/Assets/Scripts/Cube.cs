using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public Cube()
    {
        base.Color = Color.red;
    }

    public override string DisplayText()
    {
        return "Hello I am a Cube";
    }

    private void Start()
    {
        this.GetComponent<Renderer>().material.SetColor("_Color", base.Color);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public Color Color { get; set; }

    // ENCAPSULATION
    private string name;
    public string Name
    {
        get => this.name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new System.Exception("Name can't be empty");
            this.name = value;
        }
    }

    [SerializeField]
    private TMP_Text textHolder;

    // POLYMORPHISM
    public abstract string DisplayText();

    // ABSTRACTION
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit))
            {
                if(hit.transform == this.transform)
                {
                    StartCoroutine(DisplayTextOnScreen());
                }
            }
        }
    }

    private IEnumerator DisplayTextOnScreen()
    {
        textHolder.text = DisplayText();
        yield return new WaitForSeconds(5);
        textHolder.text = "";
    }
}

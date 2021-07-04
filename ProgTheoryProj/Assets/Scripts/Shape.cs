using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public Color Color { get; set; }
    [SerializeField]
    private TMP_Text textHolder;

    public abstract string DisplayText();

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

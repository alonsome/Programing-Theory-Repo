using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    Vector3 scaleChange;
    Renderer m_renderer;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        m_renderer = GetComponent<Renderer>();
        m_Color = "Green";
        m_Name = "Sphere";
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSize();
    }

    public override string SayColor()
    {
        Color color = m_renderer.material.color;
        return m_text = "My color is " + color.ToString();
    }
    public override void OnMouseDown()
    {
        m_UGUI.text = SayColor()+ " and I am  a "+GetName();
    }

    private void ChangeSize()
    {//ABSTRACTION
        transform.localScale += scaleChange;
        if (transform.localScale.y < 0.1f)
        {
            scaleChange = -scaleChange;
        }
        else if (transform.localScale.y > 5f)
        {
            scaleChange = -scaleChange;
        }
    }
}

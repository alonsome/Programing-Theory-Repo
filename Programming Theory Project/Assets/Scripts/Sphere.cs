using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        m_Color = "Green";
        m_Name = "Sphere";
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSize();
    }

    public override void SayColor()
    {
        throw new System.NotImplementedException();
    }

    private void ChangeSize()
    {
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

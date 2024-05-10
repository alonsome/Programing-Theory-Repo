using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        m_Name = "Cylinder";
        m_Color = "Orange";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override string SayColor()
    {
        return GetColor();
    }
}

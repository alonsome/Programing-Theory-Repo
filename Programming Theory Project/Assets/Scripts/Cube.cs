using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        m_Color = "Red";
        m_Name = "Cube";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void SayColor()
    {
        Debug.Log("My color is: "+m_Color);
    }
}

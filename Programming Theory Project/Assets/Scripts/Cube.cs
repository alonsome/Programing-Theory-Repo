using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cube : Shape
{//INHERITANCE
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Color = "Red";
        m_Name = "Cube";
    }

    // Update is called once per frame
    void Update()
    {
        RotateCube();
    }
    public override void SayColor()
    {
        Debug.Log("My color is: "+m_Color);
    }

    //ABSTRACTION
    private void RotateCube()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}

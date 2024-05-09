using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Base class for all the shapes
public abstract class Shape : MonoBehaviour
{
    //Encapsulation
    protected string m_Color;
    protected string m_Name;
    public string Color{ get; private set; }
    public string Name
    {
        set {
            if (string.IsNullOrEmpty(value))
            {
                Debug.LogError("The shape must have a name");
            }
            else
            {
                m_Name = value;
            }
        }
        get { return m_Name; }
    }
    
    public void OnMouseDown()
    {
        DisplayText();
        SayColor();
    }
    //POLYMORPHISM
    public virtual void DisplayText()
    {
        Debug.Log("Hi, I am a "+m_Name);
    }

    public abstract void SayColor();


}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//Base class for all the shapes
public abstract class Shape : MonoBehaviour
{
    //Encapsulation
    protected string m_Color;
    protected string m_Name;
    protected string m_text;
    [SerializeField] protected TextMeshProUGUI m_UGUI;
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
    public string Text { get; private set; }

    public virtual void OnMouseDown()
    {
        m_UGUI.text=DisplayText();
        //SayColor();
    }
    //POLYMORPHISM
    public virtual string DisplayText()
    {
        return m_text = "Hi, I am a " + m_Name + " and my color is "+m_Color;
        //Debug.Log(m_text);
    }

    //public abstract void SayColor();
    public abstract string SayColor();

    public string GetName()
    {
        return m_Name;
    }

    public string GetColor()
    {
        return m_Color;
    }

}

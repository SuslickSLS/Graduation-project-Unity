using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Sloi
{
    //Значение для перемещения
    [SerializeField]
    private float value;
    [SerializeField]
    private int nameSloi;


    public float Value
    {
        get
        {
            return value;
        }
 
        protected set { }
    }

    public int NameSloi
    {
        get
        {
            return nameSloi;
        }
        protected set { }
    }

}

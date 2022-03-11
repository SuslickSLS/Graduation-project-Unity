using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ActionForPlayer
{
    [Tooltip("Id")]
    [SerializeField]
    private string id;
    public string Id
    {
        get
        {
            return id;
        }

        protected set { }
    }



    [Tooltip("Имя предмета")]
    [SerializeField]
    private string name;
    public string Name
    {
        get
        {
            return name;
        }

        protected set { }
    }



    [Tooltip("Маска спрайта")]
    [SerializeField]
    private Sprite sprite;
    public Sprite Sprite
    {
        get
        {
            return sprite;
        }

        protected set { }
    }


    [Tooltip("Диалог разговоре")]
    [SerializeField]
    private string talk;
    public string Talk
    {
        get
        {
            return talk;
        }
        protected set
        {

        }
    }



    [Tooltip("Диалог приосмотре")]
    [SerializeField]
    private string explore;
    public string Explore
    {
        get
        {
            return explore;
        }
        protected set
        {

        }
    }
}

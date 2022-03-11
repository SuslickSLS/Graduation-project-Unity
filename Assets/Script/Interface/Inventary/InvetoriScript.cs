using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvetoriScript : MonoBehaviour
{
    [SerializeField]
    private bool[] isFull;

    public bool[] IsFull {

        get
        {
            return isFull;
        }

        protected set { }
    }



    [SerializeField]
    private GameObject[] slots;

    public GameObject[] Slots
    {

        get
        {
            return slots;
        }

        protected set { }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private ActionNavigation Action;

    ////Разговор
    //private bool IsTalk;
    ////Осмотр
    //private bool IsExplore;


    private void Update()
    {
        ActionPlayer();
    }



    private void ActionPlayer()
    {
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    Action.idAction = 1;
        //    Debug.Log("Разговор");
        //}
        //else if (Input.GetKeyDown(KeyCode.W))
        //{
        //    Action.idAction = 2;
        //    Debug.Log("Осмотр");
        //}
        //else
        //{
        //    Action.idAction = 0;
        //}
    }
}


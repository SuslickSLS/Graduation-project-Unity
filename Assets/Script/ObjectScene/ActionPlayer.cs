using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public class ActionPlayer : MonoBehaviour
{
    //id объекта
    [SerializeField]
    private int Id;

    //id действующего объекта
    [SerializeField]
    private CollectionObject collectionObject;
    [SerializeField]
    private ActionNavigation action;


    private string result;
    private int actionActive;
    //private bool enterTrigger = false;


    private InvetoriScript invetory;
    [SerializeField]
    private GameObject prefabs;

    [SerializeField]
    private GameObject MeshObject;

    private NavMeshSurface2d navMeshSurface2D;

    private void Start()
    {
        invetory = GameObject.FindGameObjectWithTag("Player").GetComponent<InvetoriScript>();
        navMeshSurface2D = MeshObject.GetComponent<NavMeshSurface2d>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && actionActive != 0 /*&& enterTrigger*/)
        {
            if (actionActive == 1)
            {
                Talk();
            }
            else if (actionActive == 2)
            {
                Explore();
            }
            else if(actionActive == 3)
            {
                
                Give();
            }
            Debug.Log(result);
            collision.gameObject.GetComponent<NavMeshAgent>().ResetPath();

        }

    }

    private void Update()
    {
        

        //Talk
        ActionKey(KeyCode.Q, 1);
        //Explore
        ActionKey(KeyCode.W, 2);
        //Give
        ActionKey(KeyCode.E, 3);
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    enterTrigger = false;
    //    action.idAction = 0;
    //    actionActive = 0;
    //}

    private void OnMouseDown()
    {
        
        actionActive = action.idAction;
    }

    private void Talk()
    {
        result = collectionObject.DataObjects[Id].Talk;
    }

    private void Explore()
    {
        result = collectionObject.DataObjects[Id].Explore;
    }

    private void Give()
    {
        for (int i = 0; i < invetory.Slots.Length; i++)
        {
            if(invetory.IsFull[i] == false )
            {
                invetory.IsFull[i] = true;

                var prefabIstal = Instantiate(prefabs, invetory.Slots[i].transform);

                prefabIstal.GetComponent<SpriteRenderer>().sprite = collectionObject.DataObjects[Id].Sprite;

                Destroy(gameObject);
                result = "Взял";
                navMeshSurface2D.BuildNavMesh();
                break;
            }
        }
    }



    private void ActionKey(KeyCode key, int idAction)
    {
        if (Input.GetKeyDown(key))
        {
            action.idAction = idAction;
        }
        else if (Input.GetKeyUp(key))
        {
            action.idAction = 0;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wallk : MonoBehaviour
{
   
    private float size;

    //private Animator anim;
    [SerializeField]
    private Sloi[] sloi;

    //[SerializeField]
    //private GameObject Window;

    //[SerializeField]
    //public VectorValue pos;

    private Vector3 Tposition;

    //[SerializeField]
    //public Texture2D cursorTexture;
    //[SerializeField]
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

    private NavMeshAgent agent;

    private Vector3 start;

    private Component component;
    private Vector3 Prepos;
    private Vector3 nowPos;
    void Start()
    {
        //transform.position = pos.initialPos;
        //anim = GetComponent<Animator>();
        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;



        start = transform.position;
        nowPos = transform.position;



        SizeChange();
    }

    private void GotoSloi()
    {
        if (transform.position.y >= sloi[0].Value)
        {
            GetComponent<SpriteRenderer>().sortingOrder = sloi[0].NameSloi;
        }
        else if (transform.position.y < sloi[0].Value && transform.position.y > sloi[1].Value)
        {
            GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
        else
        {
            GetComponent<SpriteRenderer>().sortingOrder = sloi[1].NameSloi;
        }
    }
    
    private void SizeChange()
    {
        size = 10f - (transform.position.y / 1.5f);
        if (size < 0)
        {
            size *= -1;
        }
        transform.localScale = new Vector3(size, size, size);
    }
    void Update()
    {
        Prepos = transform.position;
        //agent = GetComponent<NavMeshAgent>();

        SizeChange();

        //if (Prepos == nowPos)
        //{
        //    anim.SetBool("IsRunner", false);

        //}
        //else
        //{
        //    anim.SetBool("IsRunner", true);

        //}

        //Передвижение персонажа
        if (Input.GetMouseButtonDown(0))
        {

            Tposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            agent.SetDestination(Tposition);

        }

        GotoSloi();

        nowPos = Prepos;
    }

   
}

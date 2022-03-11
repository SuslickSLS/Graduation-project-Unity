using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundScript : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;

    private void OnMouseDown()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        agent.SetDestination(position);
    }
}

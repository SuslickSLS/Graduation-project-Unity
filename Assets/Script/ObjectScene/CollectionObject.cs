using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CollectionAnswer", menuName = "DataObjects/CollectionObject", order = 1)]
public class CollectionObject : ScriptableObject
{

    [SerializeField]
    private ActionForPlayer[] dataObjects;

    public ActionForPlayer[] DataObjects => dataObjects;
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RelationshipManager : MonoBehaviour
{
    public int[,] relationshipMatrix = new int[25,25];

    public RChar[] charList = new RChar[25];

    public RChar getCharacterByID(int charID)
    {
        return charList[charID];
    }

    public int getRelationship (int actorID, int targetID)
    {
        return relationshipMatrix[actorID, targetID];
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType_", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    public bool displayInNodeGraphEditor = true;

    [Header("One type should be a corridor")]
    public bool isCorridor;

    [Header("One type shouelds be a corridorNS")]
    public bool isCorridorNS;

    [Header("One type should be a corridorEW")]
    public bool isCorridorEW;

    [Header("One type should be an entrance")]
    public bool isEntrance;

    [Header("One type should be a Boss Room")]
    public bool isBossRoom;

    [Header("One type should be none (unassigned)")]
    public bool isNone;

#if UNITY_EDITOR

    private void OnValidate()
    {
        HelperUtilites.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }

#endif
}
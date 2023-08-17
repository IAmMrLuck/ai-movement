using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAISquadMovement : MonoBehaviour
{
    [SerializeField] private List<SimpleAiBrain> squadMembers;

    [SerializeField] private Transform[] squadPositions;


    private void Update()
    {
        for (int i = 0; i < squadMembers.Count; i ++)
        {
            if (squadMembers[i].currentTactics == SimpleAiBrain.Tactics.SquadPattern)
            {
                squadMembers[i].meshAgent.SetDestination(squadPositions[i].position);
            }
        }
    }


}

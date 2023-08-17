using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAiBrain : MonoBehaviour
{

    public NavMeshAgent meshAgent;
    [SerializeField] private Vector3 playerDest;
    [SerializeField] private SimpleAiVision vision;

    public enum Tactics { Undefined, NoPattern, SquadPattern }
    public Tactics currentTactics = Tactics.Undefined;

    private void Start()
    {
        //Vector3 playerFollow = new Vector3(-12, 0, -5);
        //meshAgent.SetDestination(playerDest);
    }

    private void Update()
    {
        if(currentTactics == Tactics.NoPattern)
        {
            if (vision != null)
            {
                Debug.Log("First Vision Check");

                if (vision.playerCharacter != null)
                {
                    Debug.Log("Vision is " + vision.name);
                    meshAgent.SetDestination(vision.playerCharacter.transform.position);
                }
            }

        }

        //if (Vector3.Distance(transform.position, playerDest) < 2)
        //{
        //    meshAgent.isStopped = true;
        //}
    }

}

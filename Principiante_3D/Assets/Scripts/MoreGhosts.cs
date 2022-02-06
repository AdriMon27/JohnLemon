using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoreGhosts : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform player;

    private Vector3 originPosition;

    void Start()
    {
        originPosition = GetComponent<Transform>().position;
        navMeshAgent.SetDestination(player.position);
    }

    void Update()
    {
        if (!SafeZone.playerInSafeZone) {
            navMeshAgent.SetDestination(player.position);
        }
        else {
            navMeshAgent.SetDestination(originPosition);
        }
    }
}

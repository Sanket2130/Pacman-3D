using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent  navMeshAgent;
    public void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    

    // Update is called once per frame
    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }
}

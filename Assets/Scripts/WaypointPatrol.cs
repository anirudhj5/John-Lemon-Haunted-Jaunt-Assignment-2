using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrWaypointIndex;

    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
        
    }
   
    void Update()
    {
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrWaypointIndex = (m_CurrWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrWaypointIndex].position);
        }
        
    }
}

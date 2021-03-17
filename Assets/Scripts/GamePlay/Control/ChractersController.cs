using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharactersContoller : MonoBehaviour
{
    protected NavMeshAgent navMeshAgent;
    protected Camera characterCamera;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        characterCamera = Camera.main;
    }

}

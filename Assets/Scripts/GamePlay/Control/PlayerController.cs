using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharactersContoller
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MoveToSelectedPoint();
        }
    }

    private void MoveToSelectedPoint()
    {
        var ray = characterCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit))
            navMeshAgent.SetDestination(hit.point);
    }
}

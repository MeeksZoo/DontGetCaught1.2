using UnityEngine;
using UnityEngine.AI;

public class MoveOnMouseDown : MonoBehaviour {

    NavMeshAgent Movee;

    void Start()
    {
        Movee = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                Movee.destination = hit.point;
            }
        }
    }
}
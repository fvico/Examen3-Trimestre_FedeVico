using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class Player : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agen;
    public static int numeroLLaves;
    // Start is called before the first frame update
    void Start()
    {
        numeroLLaves = 0;
        agen = GetComponent<NavMeshAgent>();
        //agen.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Vector3 porsicionRaton = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(porsicionRaton);

            bool haColisionado = Physics.Raycast(ray, out hit);

            if (haColisionado)
            {
                agen.SetDestination(hit.point);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "key")
        {
            numeroLLaves++;
            Debug.Log(numeroLLaves);
            Destroy(other.gameObject);
        }
    }
}


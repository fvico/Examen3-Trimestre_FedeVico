using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[RequireComponent(typeof(NavMeshAgent))]

public class Player : MonoBehaviour
{
    private NavMeshAgent agen;
    public static int numeroLLaves;
    public Text textNumeroLlaves;
    private Animator animacion;
    // Start is called before the first frame update
    void Start()
    {
        numeroLLaves = 0;
        animacion = GetComponent<Animator>();
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
            textNumeroLlaves.text = "LLaves: " + numeroLLaves.ToString();
            animacion.SetTrigger("PickUp");
            Destroy(other.gameObject);
        }
    }
}


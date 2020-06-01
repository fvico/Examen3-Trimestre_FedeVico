using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBullet;
    [SerializeField]
    float timeShot;
    public GameObject target;
    public Transform spawnShot;

    private void Start()
    {
        InvokeRepeating("Disparar", 3f, timeShot);
    }

    private void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
    }
    void Disparar()
    {
        Vector3 position = new Vector3(spawnShot.position.x, spawnShot.position.y, spawnShot.position.z);
        Instantiate(prefabBullet,position, Quaternion.identity);
    }
}

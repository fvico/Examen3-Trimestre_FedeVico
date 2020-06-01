using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemigo : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBullet;
    [SerializeField]
    float timeShot;
    public GameObject target;
    public Transform spawnShot;
    private Rigidbody rgb;
    [Range(0,100)]
   public float speed;
    Animator animaciones;

    private void Start()
    {
        InvokeRepeating("Disparar", 3f, timeShot);
        rgb = GetComponent<Rigidbody>();
        animaciones = GetComponent<Animator>();
    }

    private void Update()
    {
        //transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
        MoveEnemi();
    }
    void Disparar()
    {
        Vector3 position = new Vector3(spawnShot.position.x, spawnShot.position.y, spawnShot.position.z);
        Instantiate(prefabBullet,position, Quaternion.identity);
        animaciones.SetTrigger("shot");
    }

    void MoveEnemi()
    {
        rgb.velocity = new Vector3(speed, rgb.velocity.y, rgb.velocity.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LimiteEnemigo")
        {
            speed = speed * -1;
           if (VidaEnemigo.currentVida <= 0)
            {
                speed = 0;
                animaciones.SetTrigger("Dead");
            }

        }
    }
}

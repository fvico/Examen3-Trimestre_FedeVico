using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class bullet : MonoBehaviour
{
    [SerializeField][Range(0, -10)]
     float speed;
    [SerializeField]
    float lifeBullet;
    private Rigidbody rgb;

    private void Start()
    {
        rgb = GetComponent<Rigidbody>();
        Destroy(gameObject, lifeBullet);
    }
    private void FixedUpdate()
    {
        rgb.velocity = new Vector3(rgb.velocity.x, rgb.velocity.y, speed );
    }
}

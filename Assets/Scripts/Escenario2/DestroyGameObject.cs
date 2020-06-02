using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    [SerializeField]
    [Range(0, 60)]
    private float timeToDestroy;
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}

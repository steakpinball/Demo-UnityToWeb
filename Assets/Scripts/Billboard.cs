using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform camera;
    
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }
    
    private void LateUpdate()
    {
        _transform.rotation = camera.rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] Camera camera;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera.transform);
    }
}

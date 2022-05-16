using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfOutsideBounds : MonoBehaviour
{
    [SerializeField] private GameObject collidingObject;

    private void Start()
    {

        if (!collidingObject.GetComponent<MeshCollider>().bounds.Contains(transform.position))
        {
            this.gameObject.SetActive(false);
        }
    }
}

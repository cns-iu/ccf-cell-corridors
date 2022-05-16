using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDots : MonoBehaviour
{
    private int numDots;
    [SerializeField] private int factor;
    [SerializeField] private GameObject pre_Dot;
    [SerializeField] private List<Color> colors = new List<Color>();
    [SerializeField] private float minMaxTranslate;

    void Awake()
    {
        for (int k = 0; k < factor; k++)
        {
            for (int i = 0; i < GetComponent<MeshCollider>().sharedMesh.vertices.Length; i++)
            {
                GameObject dot = Instantiate(pre_Dot, new Vector3(GetComponent<MeshCollider>().sharedMesh.vertices[i].x, GetComponent<MeshCollider>().sharedMesh.vertices[i].y, GetComponent<MeshCollider>().sharedMesh.vertices[i].z), Quaternion.identity);
                float t = Random.Range(0f, 1f);
                dot.GetComponent<SpriteRenderer>().color = Color.Lerp(colors[0], colors[1], t);

                dot.transform.Translate(new Vector3(
                    (GetComponent<MeshCollider>().sharedMesh.bounds.center.x - dot.transform.position.x / 4) + Random.Range(-minMaxTranslate, minMaxTranslate),
                    (GetComponent<MeshCollider>().sharedMesh.bounds.center.y - dot.transform.position.y / 4) + Random.Range(-minMaxTranslate, minMaxTranslate),
                    (GetComponent<MeshCollider>().sharedMesh.bounds.center.z - dot.transform.position.z / 4) + Random.Range(-minMaxTranslate, minMaxTranslate)
                    ));
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject Prefab;
    public int startAfter;
    public int repeat;
    public float minHeight;
    public float maxHeight;

    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),startAfter,repeat);
    }

    public void Spawn()
    {
        GameObject pipes = Instantiate(Prefab,transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }
}

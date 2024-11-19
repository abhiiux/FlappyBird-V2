using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }


}

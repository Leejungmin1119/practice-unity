using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 흐름 : MonoBehaviour
{
    Vector3 vec = new Vector3(8, 1.5f, 0);
    void Update()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, vec, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes : MonoBehaviour
{
    public int notesSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * Time.deltaTime * notesSpeed;
    }
}

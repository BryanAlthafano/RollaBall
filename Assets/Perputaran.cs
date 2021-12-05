using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perputaran : MonoBehaviour
{
    // Mensetup agar object (Capsule) dapat berputar
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

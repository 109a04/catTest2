using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("stop");
    }
}

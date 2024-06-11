using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Tracker location;
    void OnTriggerEnter(Collider other)
    {
        location.checkpoint(this.gameObject.transform.position);
    }
}

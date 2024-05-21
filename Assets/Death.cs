using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject PS;
    private void OnTriggerEnter(Collider other)
    {
        GameObject clone;
        clone = Instantiate(PS, other.gameObject.transform.position, other.gameObject.transform.rotation);
        other.gameObject.SetActive(false);
        Destroy(clone, 3f);
    }
}

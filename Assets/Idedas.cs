using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Idedas : MonoBehaviour
{
    public UnityEvent Enter;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Enter.Invoke();
    }

}

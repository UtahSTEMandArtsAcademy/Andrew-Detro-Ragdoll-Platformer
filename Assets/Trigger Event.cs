using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
public class TriggerEvent : MonoBehaviour
{
    public UnityEvent Enter;
    void OnTriggerEnter(Collider other){
        Enter.Invoke();
    }
}

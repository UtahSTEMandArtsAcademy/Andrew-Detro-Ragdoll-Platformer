using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Tracker : ScriptableObject
{
    public Vector3 Location;

    public void checkpoint(Vector3 your_mom)
    {
        Location = your_mom;
    }
}

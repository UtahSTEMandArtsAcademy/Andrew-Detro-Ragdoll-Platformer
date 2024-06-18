using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Tracker youcancallittrackerifyouwantwithalowert;
    public void NotDos(string name)
    {
        youcancallittrackerifyouwantwithalowert.Location = new Vector3(0f, -9f, 0f);
        SceneManager.LoadScene(name);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public GameObject obj;
    private bool active = true;

    private void Update()
    {
        obj.SetActive(active);
    }

    public void ActiveChanger()
    {
        active = !active;
    }
}

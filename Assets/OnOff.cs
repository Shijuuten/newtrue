using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject Objek;

    public void Trigger()
    {
        if(Objek.activeInHierarchy == false)
        {
            Objek.SetActive(true);
        }
        else
        {
            Objek.SetActive(false);
        }
    }
}

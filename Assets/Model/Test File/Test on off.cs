using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject video;

    public void Trigger()
    {
        if(video.activeInHierarchy == false)
        {
            video.SetActive(true);
        }
        else
        {
            video.SetActive(false);
        }
    }
}

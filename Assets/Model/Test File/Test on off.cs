using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject video;
    public GameObject Model;

    public void Trigger()
    {
        if(video.activeInHierarchy == false && Model.activeInHierarchy == true)
        {
            video.SetActive(true);
            Model.SetActive(false);

        }
        else
        {
            video.SetActive(false);
            Model.SetActive(true);
        }
    }
}

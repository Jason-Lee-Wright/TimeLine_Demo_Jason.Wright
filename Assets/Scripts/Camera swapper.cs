using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraswapper : MonoBehaviour
{
    public GameObject cinamatic_Camera;
    public GameObject MainCam;
    void Start()
    {
        if (MainCam == null)
        {
            MainCam.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cinamatic_Camera == null)
        {
            MainCam.SetActive(false);
        }
        else
        {
            MainCam.SetActive(true);
        }
    }
}

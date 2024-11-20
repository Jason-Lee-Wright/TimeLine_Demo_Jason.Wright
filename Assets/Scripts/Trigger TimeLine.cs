using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLine : MonoBehaviour
{
    public GameObject castle;
    public PlayableDirector timeline;

    private void Start()
    {
        castle.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        castle.SetActive(true);
        timeline.Play();
    }
}

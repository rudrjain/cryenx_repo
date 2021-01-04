using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GazingAction : MonoBehaviour
{
    List<infoScript> infos = new List<infoScript>();

    private void Start()
    {
        infos = FindObjectsOfType<infoScript>().ToList();
    }

    private void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {
                OpenInfo(go.GetComponent<infoScript>());
            }
        }
        else
        {
            CloseAll();
        }
    }
    void OpenInfo(infoScript desiredInfo)
    {
        foreach (infoScript info in infos)
        {
            if (info == desiredInfo)
            {
                info.OpenInfo();
            }
            else
            {
                info.CloseInfo();
            }
        }
    }

    void CloseAll()
    {
        foreach (infoScript info in infos)
        {
            info.CloseInfo();
        }
    }
}

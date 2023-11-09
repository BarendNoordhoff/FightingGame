using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPointer : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraPointerSubject;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(cameraPointerSubject.transform);
    }
}

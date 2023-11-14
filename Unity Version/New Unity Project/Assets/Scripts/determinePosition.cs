using System;
using UnityEngine;

public class DeterminePosition : MonoBehaviour
{
    [SerializeField] 
    private GameObject player1;
    [SerializeField] 
    private GameObject player2;  
    // Update is called once per frame

    private Transform _cameraTransform;

    [SerializeField] 
    private Camera _camera;
    
    private void Start()
    {
        _cameraTransform = this.transform;
    }

    void Update()
    {
        float pos = (player1.transform.position.x + player2.transform.position.x) / 2;
        //float diff = player2.transform.position.x - player1.transform.position.x;
        
        LookAtSubject(pos);
        //BackOffAccordingly(diff);
    }

    void LookAtSubject(float pos)
    {
        Vector3 newPos = _cameraTransform.position;
        newPos.x = pos;
        
        _cameraTransform.position = newPos;  
    }

    // ReSharper disable Unity.PerformanceAnalysis
    /*void BackOffAccordingly(float diff)
    {
        var position = _camera.transform.position;
        
        if (diff > 13)
        {
            Debug.Log("blah");
            Mathf.Lerp(position.z, position.z + 102222, 2f);
        }
        else
        {
            Debug.Log("no blah");
            Mathf.Lerp(position.z + 102222, position.z , 2f);
        }
    }*/
}

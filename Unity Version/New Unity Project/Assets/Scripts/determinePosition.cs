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
        
        LookAtSubject(pos);
    }

    void LookAtSubject(float pos)
    {
        Vector3 newPos = _cameraTransform.position;
        newPos.x = pos;

        _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, newPos, 10f * Time.deltaTime);
    }
}

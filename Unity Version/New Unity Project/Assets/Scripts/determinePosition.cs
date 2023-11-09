using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class determinePosition : MonoBehaviour
{
    [SerializeField] 
    private GameObject player1;
    [SerializeField] 
    private GameObject player2;  
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = this.transform.position;
        newPos.x = (player1.transform.position.x + player2.transform.position.x) / 2;
        this.transform.position = newPos;
    }
}

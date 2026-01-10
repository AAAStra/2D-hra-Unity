using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;
    void Update()
    {
        transform.position = new Vector3(player.position.x, 0f, -10f)+offset;
    }
    
}

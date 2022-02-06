using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject ghost;
    public Transform positionSpawn;

    private float _timer = 0f;
    private float _timeBetweenGhosts = 1f;
    
    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > _timeBetweenGhosts) {
            Instantiate(ghost, positionSpawn.position, Quaternion.identity);

            _timer = 0f;
        }
    }
}

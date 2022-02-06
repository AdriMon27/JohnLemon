using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public static bool playerInSafeZone { get => _playerInSafeZone; }
    private static bool _playerInSafeZone = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            _playerInSafeZone = true;
            Debug.Log(playerInSafeZone);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {
            _playerInSafeZone = false;
            Debug.Log(playerInSafeZone);
        }
    }
}

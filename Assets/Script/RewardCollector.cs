using System.Collections;
using System.Collections.Generic;
// using UnityEngine.UI;
using UnityEngine;

public class RewardCollector : MonoBehaviour
{
    public GameManager gameManager;
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Collision");
        gameManager.AddScore();
        Destroy(gameObject);
    }
}

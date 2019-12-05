using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit, name " + other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            GameLogic.Instance.ObstacleGotHit();
        }
    }
}

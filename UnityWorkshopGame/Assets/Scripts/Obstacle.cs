using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            GameLogic.Instance.ObstacleGotHit();
        }
    }
}

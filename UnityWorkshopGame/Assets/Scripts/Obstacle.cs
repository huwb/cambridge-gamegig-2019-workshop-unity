using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Will be called when a rigidbody starts overlapping this object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameLogic.Instance.ObstacleGotHit();
        }
    }
}

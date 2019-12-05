using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform _cameraTarget;

    public float _lerpAmount = 0.1f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _cameraTarget.position, _lerpAmount * 60f * Time.deltaTime);
    }
}

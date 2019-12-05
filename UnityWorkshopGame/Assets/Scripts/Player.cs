using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0f, 60f)]
    public float _speed = 60f;

    public Vector3 _jumpInitialVelocity = Vector3.up * 10f;

    // Make an enum for the state
    enum JumpState
    {
        NotJumping,
        Jumping,
    }
    JumpState _jumpState = JumpState.NotJumping;

    // Jump velocity - internal state, not shown in inspector
    Vector3 _velocity = Vector3.zero;

    void Update()
    {
        if (!GameLogic.Instance.PlayerAlive)
        {
            // Player is dead, stop updating
            return;
        }

        transform.position += _speed * Vector3.forward * Time.deltaTime;

        switch (_jumpState)
        {
            case JumpState.NotJumping:

                // Detect if player presses spacebar and jump
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // Switch to jumping state

                    // Write a line to the log
                    Debug.Log("Started jumping");

                    // Set jump velocity
                    _velocity = _jumpInitialVelocity;

                    // Change state
                    _jumpState = JumpState.Jumping;
                }

                break;

            case JumpState.Jumping:
                // Move forward by velocity
                transform.position += _velocity * Time.deltaTime;

                // Apply gravitational force
                _velocity += Physics.gravity * Time.deltaTime;

                // Detect if player hits ground and stop jumping
                if (transform.position.y <= 1f)
                {
                    var pos = transform.position;
                    pos.y = 1f;
                    transform.position = pos;

                    _jumpState = JumpState.NotJumping;
                }
                break;
        }
    }
}

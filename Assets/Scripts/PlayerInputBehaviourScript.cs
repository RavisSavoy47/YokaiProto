using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviourScript : MonoBehaviour
{
    private MovementBehaviourScript _playerMovement;
    [SerializeField]
    private FireBehaviourScript _gun;

    private void Awake()
    {
        _playerMovement = GetComponent<MovementBehaviourScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //lets the player move only left or right
        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0).normalized;

        //throws a projectitle when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _gun.Fire();
        }
    }
}

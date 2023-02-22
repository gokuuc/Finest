using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController characterController;

    [SerializeField] Auto_Movement time;

    public float speed = 5f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (time.currentT < 0f)
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            characterController.Move(move * Time.deltaTime * speed);
        }
    }
}

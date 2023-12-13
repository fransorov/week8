using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStateManager : MonoBehaviour
{
    public float moveSpeed = 3;
    [HideInInspector] public Vector3 Dir;
    float hzInput, vInput;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        GetDirectionAndMove();
    }
    void GetDirectionAndMove()
    {
        hzInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("vertical");

        Dir = transform.forward * vInput + transform.right * hzInput;
        controller.Move(Dir * moveSpeed * Time.deltaTime);
    }
}

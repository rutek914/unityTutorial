using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 7f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1; 
        }
        inputVector = inputVector.normalized;
        Vector3 moveDirection = new Vector3 (inputVector.x, 0f, inputVector.y);
        transform.position += moveDirection * Time.deltaTime * _moveSpeed;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * 10);
        Debug.Log(inputVector);
    }
    
}

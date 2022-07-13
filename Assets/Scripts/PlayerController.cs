using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 7;
    [SerializeField] private float rotationSpeed = 0.8f;
    
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if(Touchscreen.current != null){
            Vector2 delta = Touchscreen.current.primaryTouch.delta.ReadValue();
            transform.Rotate(0, 0, delta.x * rotationSpeed);
        }
        
    }
}

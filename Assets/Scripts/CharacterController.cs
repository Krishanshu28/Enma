using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Joystick joystick;
    public float speed = 30f;
    float horizontalMove = 0f;
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
  {
    
    rigidBody = gameObject.GetComponent<Rigidbody>();
  }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal * speed;
        Vector2 movement = new Vector2(horizontalMove,0f);
         rigidBody.velocity = movement * speed;

    }
}

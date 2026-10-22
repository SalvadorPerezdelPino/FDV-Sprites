using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    Vector2 movement;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(moveAction.action.ReadValue<float>(), 0f); 
        transform.Translate(movement * Time.deltaTime * speed);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    public SpriteRenderer spriteRenderer;
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
        float moveX = moveAction.action.ReadValue<float>();
        movement = new Vector2(moveX, 0f);
        if (moveX > 0)
        {
            spriteRenderer.flipX = false;
        } else if (moveX < 0)
        {
            spriteRenderer.flipX = true;
        }
        transform.Translate(movement * Time.deltaTime * speed);
    }
}

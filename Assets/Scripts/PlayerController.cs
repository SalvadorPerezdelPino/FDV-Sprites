using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    Vector3 direction;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(moveAction.action.ReadValue<float>(), 0, 0);
        transform.Translate(direction * Time.deltaTime * speed);
    }
}

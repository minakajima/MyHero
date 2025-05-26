using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // ˆÚ“®“ü—Í‚ğ•Û‘¶‚·‚é•Ï”
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // V‚µ‚¢Input System‚Å‚Ì“ü—Íˆ—
    void OnMove(InputValue value)
    {
        // Vector2‚Æ‚µ‚Ä“ü—Í’l‚ğæ“¾
        moveInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        // moveInput‚ğg‚Á‚ÄˆÚ“®ˆ—
        transform.position += Time.deltaTime * 5.0f * new Vector3(moveInput.x, 0, moveInput.y);
    }
}

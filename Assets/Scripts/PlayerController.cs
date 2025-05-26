using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // �ړ����͂�ۑ�����ϐ�
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // �V����Input System�ł̓��͏���
    void OnMove(InputValue value)
    {
        // Vector2�Ƃ��ē��͒l���擾
        moveInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        // moveInput���g���Ĉړ�����
        transform.position += Time.deltaTime * 5.0f * new Vector3(moveInput.x, 0, moveInput.y);
    }
}

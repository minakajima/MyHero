using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // 移動入力を保存する変数
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // 新しいInput Systemでの入力処理
    void OnMove(InputValue value)
    {
        // Vector2として入力値を取得
        moveInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        // moveInputを使って移動処理
        transform.position += Time.deltaTime * 5.0f * new Vector3(moveInput.x, 0, moveInput.y);
    }
}

using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

/// <summary>
/// 실제로 이동이 일어날 컴포넌트
/// </summary>
public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // Awake는 주로 내 컴포넌트안에서 끝나는거

        // controller랑 TopDownMovement랑 같은 게임 오브젝트 안에 있다라는 가정
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move; // TopDownController에 Move 등록
    }

    /// <summary>
    /// Update에서 매프레임마다 눌려지고 있는지 판단(이동 방향)
    /// TopDownController에 등록되어 있으니가 입력이 있을 때 실행되는 함수
    /// </summary>
    /// <param name="direction"></param>
    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    /// <summary>
    /// 물리업데이트관련
    /// </summary>
    private void FixedUpdate()
    {
        // rigidbody의 값을 바꾸니까 FixedUpdate
        ApplyMovement(movementDirection);
    }

    /// <summary>
    /// 실제 움직임 처리
    /// </summary>
    /// <param name="direction"></param>
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
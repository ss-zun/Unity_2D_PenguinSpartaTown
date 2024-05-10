using System;
using Unity.VisualScripting;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }
    private void Start()
    {
        controller.OnLookEvent += OnAim; // TopDownController에 이벤트 등록
    }

    private void OnAim(Vector2 direction)
    {
        Rotate(direction);
    }

    /// <summary>
    /// 캐릭터와 마우스 사이의 각도의 절대값이 90도 이상이면 캐릭터 이미지 플립
    /// </summary>
    /// <param name="direction"></param>
    private void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Mathf.Rad2Deg -> degree로 변환

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f; // 절대값이 90도 보다 크면 캐릭터 이미지 플립
    }
}
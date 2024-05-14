using UnityEngine;

/// <summary>
/// 캐릭터 이동 애니메이션 처리
/// </summary>
public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    // walking을 하는데 너무 조금 움직이고 있으면 그냥 멈춘걸로 처리(Threshold : 문턱)
    // 0.5는 넘어야한다는 의미로 쓴 것
    private readonly float magnituteThreshold = 0.5f; 

    protected override void Awake()
    {
        base.Awake();
    }
    private void Start()
    {       
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        // 0.5보다 작으면 false, 크면 true
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}
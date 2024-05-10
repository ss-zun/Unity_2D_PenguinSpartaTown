using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
///  캐릭터 이동 이벤트 등록
/// </summary>
public class PlayerInputController : TopDownController
{
    private Camera camera;
    private void Awake()
    {
        camera = Camera.main;
    }

    /// <summary>
    /// 플레이어의 움직임이 처리된 후에 카메라를 업데이트
    /// </summary>
    private void LateUpdate()
    {
        // 카메라를 플레이어의 위치로 이동
        if (camera != null)
        {
            Vector2 playerPosition = transform.position;
            Vector3 cameraPosition = camera.transform.position;
            camera.transform.position = new Vector3(playerPosition.x, playerPosition.y, cameraPosition.z);
        }
    }

    /// <summary>
    /// 이동에 대한 전처리 작업을 바탕으로 CallMoveEvent 실행
    /// </summary>
    /// <param name="value"></param>
    public void OnMove(InputValue value) // 누른 키보드 키값의 정보가 value에 들어옴
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // Get<Vector2>()로 키값 받아오고, 크기 1인 방향 벡터로 변경
        CallMoveEvent(moveInput); // MoveEvent 발생했다고 알려주기
        // 실제 움직이는 처리는 여기가 아니라 PlayerMovement에서 함
    }

    /// <summary>
    /// 마우스 에임에 대한 전처리 작업을 바탕으로 CallLookEvent 실행
    /// </summary>
    /// <param name="value"></param>
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // 마우스 입력에서는 방향이 아닌 위치를 나타내므로 정규화를 하지 않음

        // 마우스 입력 위치를 화면 좌표계로부터 월드 좌표계로 변환
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim); 
        // 플레이어를 기준으로 한 마우스 입력 위치의 상대적인 위치
        // 이것은 마우스 입력 위치와 플레이어 사이의 방향 벡터가 됨
        // 점A에서 점B로 가는 벡터 -> B-A
        newAim = (worldPos - (Vector2)transform.position).normalized; 
        
        CallLookEvent(newAim);
    }
}
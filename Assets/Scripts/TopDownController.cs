using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TopDownController에 Action을 등록해둔다
// TopDownMovement에서 Movement가 발생했을 때
// TopDownController에 특정 메소드를 실행시켜 달라고 등록을 할 것이다
// 그러면 TopDownController에서 OnMoveEvent를 Invoke해준다
// 왜이러냐면 OnMoveEvent 할 때 이것저것 행동이 많이 발생해서 다들 등록을 할 것이다
// 등록하면 각자에게 다 알려줄 수 있다
public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action은 무조건 void만 반환해야 아니면 Func
    public event Action<Vector2> OnLookEvent;

    // OnMoveEvent가 발생했을 때 Invoke하는 역할
    // 캐릭터랑 몬스터가 CallMoveEvent하는 방식이 다르다
    // 그래서 그런 부분들은 상속받는 클래스에서 바로 잡아줄 것이다
    public void CallMoveEvent(Vector2 direction) // direction -> 어느방향으로 움직이는지
    {
        OnMoveEvent?.Invoke(direction); // ?. 없으면 말고 있으면 실행
    }

    public void CallLookEvent(Vector2 direction) 
    {  
        OnLookEvent?.Invoke(direction); 
    }
}

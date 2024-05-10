using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 캐릭터, 몬스터 등 공통적인 기능들을 넣는 곳
/// Invoke를 할 수 있도록 TopDownController에 event를 달아놓고,
/// Action을 등록할 수 있도록 만듦
/// </summary>
public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action은 무조건 void만 반환해야 아니면 Func
    public event Action<Vector2> OnLookEvent;
 
    /// <summary>
    /// OnMoveEvent가 발생했을 때 Invoke하는 역할
    /// 실행되면 전체에 뿌려준다
    /// </summary>
    /// <param name="direction"></param>
    public void CallMoveEvent(Vector2 direction) // direction -> 어느방향으로 움직이는지
    {
        OnMoveEvent?.Invoke(direction); // ?. 없으면 말고 있으면 실행
    }

    /// <summary>
    /// OnLookEvent가 발생했을 때 Invoke하는 역할
    /// 실행되면 전체에 뿌려준다
    /// </summary>
    /// <param name="direction"></param>
    public void CallLookEvent(Vector2 direction) 
    {  
        OnLookEvent?.Invoke(direction); 
    }
}
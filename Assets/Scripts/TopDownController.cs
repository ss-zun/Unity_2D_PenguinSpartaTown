using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ĳ����, ���� �� �������� ��ɵ��� �ִ� ��
/// Invoke�� �� �� �ֵ��� TopDownController�� event�� �޾Ƴ���,
/// Action�� ����� �� �ֵ��� ����
/// </summary>
public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action�� ������ void�� ��ȯ�ؾ� �ƴϸ� Func
    public event Action<Vector2> OnLookEvent;
 
    /// <summary>
    /// OnMoveEvent�� �߻����� �� Invoke�ϴ� ����
    /// ����Ǹ� ��ü�� �ѷ��ش�
    /// </summary>
    /// <param name="direction"></param>
    public void CallMoveEvent(Vector2 direction) // direction -> ����������� �����̴���
    {
        OnMoveEvent?.Invoke(direction); // ?. ������ ���� ������ ����
    }

    /// <summary>
    /// OnLookEvent�� �߻����� �� Invoke�ϴ� ����
    /// ����Ǹ� ��ü�� �ѷ��ش�
    /// </summary>
    /// <param name="direction"></param>
    public void CallLookEvent(Vector2 direction) 
    {  
        OnLookEvent?.Invoke(direction); 
    }
}
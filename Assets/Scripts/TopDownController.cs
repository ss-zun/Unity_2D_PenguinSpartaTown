using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TopDownController�� Action�� ����صд�
// TopDownMovement���� Movement�� �߻����� ��
// TopDownController�� Ư�� �޼ҵ带 ������� �޶�� ����� �� ���̴�
// �׷��� TopDownController���� OnMoveEvent�� Invoke���ش�
// ���̷��ĸ� OnMoveEvent �� �� �̰����� �ൿ�� ���� �߻��ؼ� �ٵ� ����� �� ���̴�
// ����ϸ� ���ڿ��� �� �˷��� �� �ִ�
public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action�� ������ void�� ��ȯ�ؾ� �ƴϸ� Func
    public event Action<Vector2> OnLookEvent;

    // OnMoveEvent�� �߻����� �� Invoke�ϴ� ����
    // ĳ���Ͷ� ���Ͱ� CallMoveEvent�ϴ� ����� �ٸ���
    // �׷��� �׷� �κе��� ��ӹ޴� Ŭ�������� �ٷ� ����� ���̴�
    public void CallMoveEvent(Vector2 direction) // direction -> ����������� �����̴���
    {
        OnMoveEvent?.Invoke(direction); // ?. ������ ���� ������ ����
    }

    public void CallLookEvent(Vector2 direction) 
    {  
        OnLookEvent?.Invoke(direction); 
    }
}

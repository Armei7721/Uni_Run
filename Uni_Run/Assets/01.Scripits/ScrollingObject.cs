
using UnityEngine;
// ���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public static float speed = 10f;
    void Update()
    {
        //���ӿ����� �ƴ϶��
        if (!GameManager.instance.isGameover)
        {   //�ʴ� speed�� �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}

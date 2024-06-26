using UnityEngine;

/// <summary>
/// �ǂ𐧌䂷��R���|�[�l���g
/// �ǂ̃I�u�W�F�N�g�ɃA�^�b�`���Ďg���B
/// �ǂ���葬�x�ō��ɓ������A������x���ɍs������j������B
/// </summary>
public class Boss1 : MonoBehaviour
{
    /// <summary>���ɓ�������</summary>
    [SerializeField] float m_moveSpeed = 1f;

    void Update()
    {
        // ������x���ɍs������
        if (this.transform.position.x < -10f)
        {
            // �������g��j������
            Destroy(this.gameObject);
        }

        // ��葬�x�ō��ɓ�����
        this.transform.Translate(Vector2.left * m_moveSpeed * Time.deltaTime);
    }
}

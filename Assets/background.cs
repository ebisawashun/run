using UnityEngine;

/// <summary>
/// �w�i�����X�N���[�����邽�߂̃R���|�[�l���g�B�w�i�摜�ɃA�^�b�`���Ďg���B
/// ���ƕ����������̂����ɃX�N���[�����A��ʍ��ɏ�����ƉE����o�Ă���悤�ɂȂ�B
/// �]���āA�w�i�摜�͍��E�Ɍq���Ă��悢���̂łȂ��Ă͂Ȃ�Ȃ��B
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
public class BackgroundRightToLeftScrollController : MonoBehaviour
{
    /// <summary>�w�i�̃X�N���[�����x</summary>
    [SerializeField] float m_scrollSpeed = -1f;
    SpriteRenderer m_sprite = default;

    private void Start()
    {
        m_sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // �w�i�摜���X�N���[������
        m_sprite.transform.Translate(-1 * m_scrollSpeed * Time.deltaTime, 0f, 0f);

        // �w�i�摜��������x���ɓ�������A�E�ɖ߂�
        if (m_sprite.transform.position.x < -1 * m_sprite.bounds.size.x)
        {
            m_sprite.transform.Translate(m_sprite.bounds.size.x * 2, 0f, 0f);
        }
    }

}
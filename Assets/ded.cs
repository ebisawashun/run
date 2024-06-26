using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �L�����N�^�[�𐧌䂷��R���|�[�l���g
/// �L�����N�^�[�ɃA�^�b�`���Ďg���BRigidbody2D ��K�v�Ƃ���B
/// �{�^���ŃW�����v����B
/// �����ɂԂ�������Q�[���I�[�o�[�ɂ���B
/// </summary>
public class ded : MonoBehaviour
{
    /// <summary>�X�y�[�X�L�[�����������ɏ㏸�����</summary>
    [SerializeField] float m_jumpPower = 1f;
    /// <summary>Game Over ��\������I�u�W�F�N�g</summary>
    GameObject m_gameoverText = default;
    /// <summary>�o�ߎ��Ԃ�\������I�u�W�F�N�g</summary>
    GameObject m_timeText = default;
    /// <summary>�Q�[���I�[�o�[���ǂ����𔻒f����t���O</summary>
    bool m_isGameover = false;
    Animator m_anim = default;
    Rigidbody2D m_rb = default;

    void Start()
    {
        m_anim = GetComponent<Animator>();
        // �V�[������A�K�؂ȃI�u�W�F�N�g�������E�擾����
        m_gameoverText = GameObject.Find("GameoverText");
        m_timeText = GameObject.Find("TimeText");
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // �W�����v�{�^���������ꂽ��㏸����
        if (Input.GetButtonDown("Jump"))
        {
            m_anim.Play("Flap");
            m_rb.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
        }

        // TimeText �Ƀv���C���Ԃ�\������
        if (m_isGameover == false)
            m_timeText.GetComponent<Text>().text = Time.time.ToString("F2");
        // F2 �Łu�����_�ȉ��Q���܂Łv���w�肵�āA�����𕶎���ɕϊ�����i�Q�l: https://dobon.net/vb/dotnet/string/inttostring.html�j
        
       
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�����ɂԂ������I");

        // �����ɂԂ�������Q�[���I�[�o�[�Ƃ���
        m_isGameover = true;
        // ��ʂ� Game Over �ƕ\������
        Text gameoverText = m_gameoverText.GetComponent<Text>();
        gameoverText.text = "Game Over";
    }
}

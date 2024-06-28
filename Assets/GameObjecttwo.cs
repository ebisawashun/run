using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjecttwo : MonoBehaviour
{
    /// <summary>�ǂƂ��Đ�������v���n�u</summary>
    [SerializeField] GameObject[] m_wallPrefabs = null;
    /// <summary>�ǂ𐶐�����Ԋu�i�b�j</summary>
    [SerializeField] float m_wallGenerateInterval = 2f;
    /// <summary>�ǐ����Ԋu���v�邽�߂̃^�C�}�[�i�b�j</summary>
    float m_timer = 0;

    void Start()
    {
        // ���s������ŏ��̕ǂ��������������悤�Ƀ^�C�}�[�ɒl�����Ă���
        m_timer = m_wallGenerateInterval;
    }

    void Update()
    {
        m_timer += Time.deltaTime;

        // �^�C�}�[�̒l�������Ԋu�𒴂�����
        if (m_timer > m_wallGenerateInterval)
        {
            m_timer = 0f;   // �^�C�}�[�����Z�b�g����
            int index = Random.Range(0, m_wallPrefabs.Length + 0);  // �z�񂩂�I�u�W�F�N�g��I�Ԃ��߂̃C���f�b�N�X�i�Y���j�������_���ɑI��
            GameObject go = Instantiate(m_wallPrefabs[index]);  // �v���n�u����I�u�W�F�N�g�𐶐����āA�ϐ� go �ɓ���� 
            go.transform.position = new Vector2(10f, 0.7f);   // ���������I�u�W�F�N�g�̈ʒu���߂�
        }

    }
}

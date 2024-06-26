using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjecttwo : MonoBehaviour
{
    /// <summary>壁として生成するプレハブ</summary>
    [SerializeField] GameObject[] m_wallPrefabs = null;
    /// <summary>壁を生成する間隔（秒）</summary>
    [SerializeField] float m_wallGenerateInterval = 2f;
    /// <summary>壁生成間隔を計るためのタイマー（秒）</summary>
    float m_timer = 0;

    void Start()
    {
        // 実行したら最初の壁がすぐ生成されるようにタイマーに値を入れておく
        m_timer = m_wallGenerateInterval;
    }

    void Update()
    {
        m_timer += Time.deltaTime;

        // タイマーの値が生成間隔を超えたら
        if (m_timer > m_wallGenerateInterval)
        {
            m_timer = 0f;   // タイマーをリセットする
            int index = Random.Range(0, m_wallPrefabs.Length + 0);  // 配列からオブジェクトを選ぶためのインデックス（添字）をランダムに選ぶ
            GameObject go = Instantiate(m_wallPrefabs[index]);  // プレハブからオブジェクトを生成して、変数 go に入れる 
            go.transform.position = new Vector2(10f, 0.7f);   // 生成したオブジェクトの位置を定める
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// オブジェクトを指定したターゲットに移動させるコンポーネント
/// </summary>
public class MoveToController : MonoBehaviour
{
    /// <summary>移動先を示すアンカーポイント</summary>
    [SerializeField] Transform[] m_targets = null;
    /// <summary>移動速度</summary>
    [SerializeField] float m_moveSpeed = 1f;
    /// <summary>ターゲットにこの距離まで近づいたら「到達した」と判断する距離（単位:メートル）</summary>
    [SerializeField] float m_stoppingDistance = 0.05f;

    void Update()
    {
        Exercise13();
        // Exercise14();
        // Exercise15();
        // Exercise16();
    }

    /// <summary>
    /// m_targets[0] にアサインしたオブジェクトの位置まで移動する処理を書け。
    /// </summary>
    void Exercise13()
    {
        if (Vector2.Distance(this.transform.position, m_targets[0].position) > m_stoppingDistance)
        {
            Vector3 dir = (m_targets[0].transform.position - this.transform.position).normalized * m_moveSpeed; // 移動方向の速度ベクトルを求める
            this.transform.Translate(dir * Time.deltaTime); // Update の中で移動する場合は、Time.deltaTime をかけることによりどの環境でも同じ速さで移動させる
        }
    }

    /// <summary>
    /// m_targets[] にアサインした任意の数 n のオブジェクトを巡回移動する処理を書け。
    /// 例）
    /// m_targets[0] に到達したら次は m_targets[1] に向かう
    /// m_targets[1] に到達したら次は m_targets[2] に向かう
    /// m_targets[2] に到達したら次は m_targets[3] に向かう
    /// ...
    /// m_targets[n] に到達したら次は m_targets[0] に向かう
    /// </summary>
    void Exercise14()
    {

    }

    /// <summary>
    /// m_targets[] にアサインした任意の数 n のオブジェクトを巡回移動する処理を書け。
    /// ただし、制限時間をメンバ変数として設定し、制限時間内に次のオブジェクトに到達しなかった場合は配列の次の要素のオブジェクトに移動先を切り替えよ。
    /// 例）
    /// m_targets[1] に制限時間内に到達しなかったら、その時点で m_targets[2] に向かう
    /// </summary>
    void Exercise15()
    {

    }

    /// <summary>
    /// m_targets[] にアサインした任意の数 n のオブジェクトを巡回移動する処理を書け。
    /// ただし、移動中に壁にぶつかった場合は、配列の次の要素のオブジェクトに移動先を切り替えよ。
    /// 例）
    /// m_targets[1] に移動中に何かにぶつかったら、その時点で m_targets[2] に向かう
    /// </summary>
    void Exercise16()
    {

    }
}

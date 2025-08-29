using System.Collections;
using UnityEngine;

public class ThroughBomb : MonoBehaviour
{

    [SerializeField] float throughTime = 0.2f;

    WaitForSeconds _throughTime;//コライダーが機能するまでの時間
    Collider BombCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _throughTime = new WaitForSeconds(throughTime);
        StartCoroutine("ColliderON");

        if (TryGetComponent<Collider>(out Collider _BombCollider))
        {
            BombCollider = _BombCollider;
            BombCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ColliderON()//throughTime秒後にコライダーを機能させる処理
    {

        yield return _throughTime;

        BombCollider.enabled = true;

    }
}

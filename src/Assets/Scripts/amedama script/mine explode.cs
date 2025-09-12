using Unity.VisualScripting;
using UnityEngine;

public class mineexplode : MonoBehaviour
{

    [SerializeField] float BombStrange = 10.0f;//爆発した時の強さ

    GameObject Player;
    Rigidbody PlayerRigidbody;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            PlayerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerEnter(Collider other)//プレイヤーが触れたときに起爆
    {
        if (other.tag == "Player")
        {
            PlayerRigidbody.linearVelocity = Vector3.up * BombStrange;
            Destroy(gameObject);
        }
    }
}

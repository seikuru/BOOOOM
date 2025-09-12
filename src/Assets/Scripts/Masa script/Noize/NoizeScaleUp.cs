using UnityEngine;

public class NoizeScaleUp : MonoBehaviour
{
    [SerializeField] float ScaleUpSpeed = 0.1f;

    [SerializeField] float ScaleUPMax = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 scale = transform.localScale;
        scale.x = Mathf.Min(ScaleUPMax , scale.x + Time.fixedDeltaTime * ScaleUpSpeed);
        transform.localScale = scale;
    }
}

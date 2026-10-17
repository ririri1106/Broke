
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 8f;

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(
            move * speed * Time.deltaTime,
            0,
            0
        );
    }
}

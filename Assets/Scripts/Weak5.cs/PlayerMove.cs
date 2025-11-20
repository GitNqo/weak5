using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * x * speed * Time.deltaTime);

        // âÊñ äOÇ…èoÇ»Ç¢ÇÊÇ§êßå¿
        float clampedX = Mathf.Clamp(transform.position.x, -3f, 3f);
        transform.position = new Vector3(clampedX, transform.position.y, 0);
    }
}

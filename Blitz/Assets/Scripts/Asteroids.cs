using UnityEngine;

public class Asteroids : MonoBehaviour {

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    private void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2 (18, 10));
    }

    private void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < screenBounds.x) {
            Destroy(this.gameObject);
        }
    }
}

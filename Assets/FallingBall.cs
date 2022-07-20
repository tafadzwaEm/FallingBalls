using UnityEngine;

public class FallingBall : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private float _fallSpeed;
    public GameObject prefab;
    private bool isGameOver;

    void Start() {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
        _fallSpeed = 20f;
        isGameOver = false;
    }
    void Update() {
        _rb2D.AddForce(new Vector2(0.0f,-_fallSpeed * Time.deltaTime),ForceMode2D.Impulse);
    }

    // Spawn ball
    public void SpawnBall() {
        Instantiate(prefab,new Vector3(Random.Range(-26,26),10f,0.0f),Quaternion.identity);
    }

    // Check for collision with player
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player" && isGameOver == false)
        {
            Debug.Log("Collided with player");
            SpawnBall();
            Destroy(gameObject);

        }else if (collisionInfo.gameObject.tag == "BackWall")
        {
            Debug.Log("Collided with back wall");
            isGameOver = true;
        }
    }

}

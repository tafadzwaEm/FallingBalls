using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private Rigidbody2D _rb2D;
    private float _moveHorizontal;
    private float _moveSpeed;
    public FallingBall fallingBall;
    // Start is called before the first frame update
    void Start()
    {   
        //Grab the rigidbody component of the player
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
        fallingBall.SpawnBall();
    }

    void Update() {
        _moveHorizontal = Input.GetAxisRaw("Horizontal"); //listen for user input
        _moveSpeed = 150f;
    }

    // Player movement
    void FixedUpdate()
    {
        if (_moveHorizontal != 0) {
            _rb2D.AddForce(new Vector2(_moveHorizontal * _moveSpeed * Time.deltaTime, 0f),ForceMode2D.Impulse);
        }
    }

    
}

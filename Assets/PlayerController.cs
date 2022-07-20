using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private Rigidbody2D _rb2D;
    private float _moveHorizontal;
    private float _moveSpeed;
    // Start is called before the first frame update
    void Start()
    {   
        //Grab the rigidbody component of the player
        _rb2D = gameObject.GetComponent<Rigidbody2D>();  
    }

    void Update() {
        _moveHorizontal = Input.GetAxisRaw("Horizontal"); //listen for user input
        _moveSpeed = 150f;
    }

    // 
    void FixedUpdate()
    {
        if (_moveHorizontal != 0) {
            _rb2D.MovePosition(new Vector2(transform.position.x + _moveHorizontal * _moveSpeed * Time.deltaTime, 0f));
        }
    }
}

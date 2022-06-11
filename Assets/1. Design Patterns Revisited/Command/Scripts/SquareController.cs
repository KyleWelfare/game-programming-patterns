using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class SquareController : MonoBehaviour
{
    [SerializeField] private CommandRecorder actionRecorder;
    private PlayerInput controls;
    private SpriteRenderer squareSR;

    private const int xBound = 4;
    private const int yBound = 2;

    [SerializeField] private float moveCooldown = 0.2f;
    private float moveCounter;

    void Awake() {
        squareSR = GetComponent<SpriteRenderer>();
        controls = new PlayerInput();
        controls.Command.Move.performed += ctx => {
            Vector2 direction = ctx.ReadValue<Vector2>();
            if (direction != Vector2.zero) {
                Command command = new MoveCommand(this, direction);
                actionRecorder.Record(command);
            }
        };
        controls.Command.ChangeColor.performed += _ => {
            Command command = new ChangeColorCommand(this, this.squareSR.color);
            actionRecorder.Record(command);
        };
        controls.Command.Rotate.performed += _ => {
            Command command = new RotateCommand(this);
            actionRecorder.Record(command);
        };
        controls.Command.Undo.performed += _ => actionRecorder.Undo();
    }

    void OnEnable() {
       controls.Enable();
    }

    void OnDisable() {
        controls.Disable();
    }

    private void Update() {
        if (moveCounter > 0) {
            moveCounter -= Time.deltaTime;
        }
    }

    public void Move(Vector2 direction) {
        if (moveCounter <= 0) {
            if (direction.x != 0) {
                if (direction.x > 0 && transform.position.x == xBound) {
                    return;
                } else if (direction.x < 0 && transform.position.x == xBound * -1) {
                    return;
                }
                transform.position = new Vector2(transform.position.x + direction.x, transform.position.y);
            } else {
                if (direction.y > 0 && transform.position.y == yBound) {
                    return;
                } else if (direction.y < 0 && transform.position.y == yBound * -1) {
                    return;
                }
                transform.position = new Vector2(transform.position.x, transform.position.y + direction.y);
            }   
        }
        moveCounter = moveCooldown;
    }

    public void ChangeColor(Color color) {
        Debug.Log(color);
        squareSR.color = color.Equals(new Color(0,0,0,0)) ? Random.ColorHSV() : color;
    }

    public void Rotate(int sign) {
        transform.Rotate(new Vector3(0, 0, 90 * sign));
    }
}

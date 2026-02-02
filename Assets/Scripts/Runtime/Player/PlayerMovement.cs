using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Camera m_mainCamera;
    [SerializeField] private const float k_MovementSpeed = 5f;
    [SerializeField] private const float k_RotationSpeed = 100f;
    private void Awake()
    {
        m_mainCamera = gameObject.GetComponent<Camera>();
    }
    private void Update()
    {
        Move();
        Rotate();
    }
    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * k_MovementSpeed * Time.deltaTime);
    }
    private void Rotate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y"));
        transform.Rotate(Vector3.up * mouseDelta.x * k_RotationSpeed * Time.deltaTime);
        m_mainCamera.transform.Rotate(Vector3.right * mouseDelta.y * k_RotationSpeed * Time.deltaTime);
    }
}
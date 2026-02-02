using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Camera m_mainCamera;
    [SerializeField] private float m_MovementSpeed = 5f;
    [SerializeField] private float m_RotationSpeed = 10f;
    private void Awake()
    {
        m_mainCamera = gameObject.GetComponentInChildren<Camera>();
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
        transform.Translate(direction * m_MovementSpeed * Time.deltaTime);
    }
    private void Rotate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"),-Input.GetAxis("Mouse Y"));
        transform.Rotate(Vector3.up * mouseDelta.x * m_RotationSpeed * Time.deltaTime);
        m_mainCamera.transform.Rotate(Vector3.right * mouseDelta.y * m_RotationSpeed * Time.deltaTime);
    }
}
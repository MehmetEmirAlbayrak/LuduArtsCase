using UnityEngine;

/// <summary>
/// Oyuncu hareketi ve fare ile bakış (yaw/pitch) kontrolünü yönetir.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region Fields

    private const float k_MovementSpeed = 5f;
    private const float k_MouseSensitivity = 2f;
    private const float k_PitchMin = -80f;
    private const float k_PitchMax = 80f;
    private const float k_YawMin = -45f;
    private const float k_YawMax = 45f;

    [SerializeField] private float m_MovementSpeed = k_MovementSpeed;
    [SerializeField] private float m_MouseSensitivity = k_MouseSensitivity;
    [SerializeField] private float m_PitchMin = k_PitchMin;
    [SerializeField] private float m_PitchMax = k_PitchMax;
    [SerializeField] private float m_YawMin = k_YawMin;
    [SerializeField] private float m_YawMax = k_YawMax;

    private Rigidbody m_Rigidbody;
    private float m_Yaw;
    private float m_Pitch;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    #endregion

    #region Methods

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * m_MovementSpeed * Time.deltaTime);
        m_Rigidbody.linearVelocity = Vector3.zero;
    }

    private void Rotate()
    {
        Cursor.lockState = CursorLockMode.Locked;

        m_Yaw += Input.GetAxis("Mouse X") * m_MouseSensitivity;
        m_Yaw = Mathf.Clamp(m_Yaw, m_YawMin, m_YawMax);
        m_Pitch -= Input.GetAxis("Mouse Y") * m_MouseSensitivity;
        m_Pitch = Mathf.Clamp(m_Pitch, m_PitchMin, m_PitchMax);

        transform.rotation = Quaternion.Euler(m_Pitch, m_Yaw, 0f);
    }

    #endregion
}

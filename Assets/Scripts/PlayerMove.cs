using UnityEngine;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 4f;
    public float sensitivity = 2f;
    public Transform cam;

    CharacterController cc;
    float pitch;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // look
        transform.Rotate(0f, Input.GetAxis("Mouse X") * sensitivity, 0f);
        pitch = Mathf.Clamp(pitch - Input.GetAxis("Mouse Y") * sensitivity, -80f, 80f);
        cam.localEulerAngles = new Vector3(pitch, 0f, 0f);

        // walk
        Vector3 move = transform.right * Input.GetAxis("Horizontal")
                     + transform.forward * Input.GetAxis("Vertical");
        cc.Move((move * speed + Vector3.down * 9.8f) * Time.deltaTime);
    }
}
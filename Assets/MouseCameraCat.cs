using UnityEngine;

public class MouseCameraCat : MonoBehaviour
{
    public Vector2 mouseMove;//storage mouse move in x,y direction
    public float sensity = -5f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseMove.x += Input.GetAxis("Mouse X") * sensity;
        mouseMove.y += Input.GetAxis("Mouse Y") * sensity;
        transform.localRotation = Quaternion.Euler(-mouseMove.y, -mouseMove.x, 0);
    }

}

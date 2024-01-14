using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 1f; // Speed of zooming
    public float minSize = 10f;   // Minimum size of the camera
    public float maxSize = 50f;  // Maximum size of the camera

    private Camera cam;          // Reference to the camera component

    void Start()
    {
        // Get the Camera component from the GameObject this script is attached to
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // Check if the camera is orthographic
        if (cam.orthographic)
        {
            // Get the scroll wheel input
            float scroll = Input.GetAxis("Mouse ScrollWheel");

            // Adjust the camera size based on the scroll input
            cam.orthographicSize -= scroll * zoomSpeed;

            // Clamp the size to be within the min and max limits
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize);
        }
    }
}

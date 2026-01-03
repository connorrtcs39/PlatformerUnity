using UnityEngine;

public class thirdpersoncamera : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float sensitivity = 3f;
    public float yMin = -20f;
    public float yMax = 60f;
    private float yaw = 0f;
    private float pitch = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * sensitivity;
        pitch -= Input.GetAxis("Mouse Y") * sensitivity;
        pitch = Mathf.Clamp(pitch,yMin,yMax);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);
        Vector3 offset = rotation * new Vector3(0, 0, -distance);
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}

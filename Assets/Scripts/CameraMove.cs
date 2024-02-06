using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform rocket;
    private Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - rocket.position;
    }

    private void Update()
    {
        if(rocket)
            gameObject.transform.position = rocket.position + cameraOffset;
    }
}

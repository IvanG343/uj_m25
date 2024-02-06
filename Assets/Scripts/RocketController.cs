using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] Vector3 rocketScaleMultiplier;
    [SerializeField] float rocketSpeed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
            ChangeScale();
        if(Input.GetKeyDown(KeyCode.E))
            LaunchRocket();
        if(Input.GetKeyDown(KeyCode.Space))
            DestroyRocket();
    }

    public void ChangeScale()
    {
        gameObject.transform.localScale += rocketScaleMultiplier;
    }

    public void LaunchRocket()
    {
        rb.AddForce(Vector3.up * rocketSpeed, ForceMode.Impulse);
    }

    public void DestroyRocket()
    {
        Destroy(gameObject);
    }
}

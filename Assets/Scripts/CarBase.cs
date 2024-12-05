using UnityEngine;

public class CarBase : MonoBehaviour
{
    public WheelCollider frontLeft, frontRight, rearLeft, rearRight;
    public Transform frontLeftMesh, frontRightMesh, rearLeftMesh, rearRightMesh;
    public float motorForce = 1500f; // Engine power
    public float brakeForce = 3000f; // Brake force
    public float maxSteerAngle = 30f; // Maximum steering angle

    private Rigidbody rb;
    private int currentGear = 0;
    private float[] gearRatios = { 2.66f, 1.78f, 1.30f, 1.00f, 0.74f }; // Example ratios
    private float gearChangeRPM = 5000f; // RPM for gear change
    private float minRPM = 800f; // Idle RPM
    private float rpm; // Current engine RPM

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput < 0) {
            
        }
    }

    private void FixedUpdate()
    {
        HandleMotor();

    }

    private void HandleMotor()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float motorTorque = verticalInput * motorForce * gearRatios[currentGear];
        rpm = Mathf.Clamp(rb.linearVelocity.magnitude * gearRatios[currentGear] * 50, 800, 5000);

        if (rpm >= 5000 && currentGear < gearRatios.Length - 1) {
            currentGear++;
        }
        else if (rpm < 800 && currentGear > 0) {
            currentGear--;
        }

        rearLeft.motorTorque = motorTorque;
        rearRight.motorTorque = motorTorque;
    }
}

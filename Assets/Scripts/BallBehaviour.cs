using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private float XRotation = 0f;
    [SerializeField] private float YRotation = 1f;
    [SerializeField] private float ZRotation = 0f;
    [SerializeField] private float DegreesPerSecond = 180f;

    private void Update()
    {
        Vector3 axis = new Vector3 (XRotation, YRotation, ZRotation);
        transform.Rotate(axis, DegreesPerSecond * Time.deltaTime);
    }
}

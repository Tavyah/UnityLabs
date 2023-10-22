using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up, 180 * Time.deltaTime);
    }
}

using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] private float XRotation = 0f;
    [SerializeField] private float YRotation = 1f;
    [SerializeField] private float ZRotation = 0f;
    [SerializeField] private float DegreesPerSecond = 180f;

    private void Update()
    {
        RotateBalls();
        ResetBalls(); 
    }

    private void RotateBalls()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f);
        YRotation += Time.deltaTime * 5f;
    }

    private void ResetBalls()
    {
        if(YRotation > 100f)
        {
            YRotation = 0f;
        }
    }
}

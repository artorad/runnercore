using UnityEngine;

public sealed class InfiniteRotation : MonoBehaviour
{
    [SerializeField] private bool rotateAroundX;
    [SerializeField] private bool rotateAroundY = true;
    [SerializeField] private bool rotateAroundZ;

    [SerializeField] private float rotationSpeed = 90f;

    private void Update()
    {
        Vector3 rotationAxis = new Vector3(
            rotateAroundX ? 1f : 0f,
            rotateAroundY ? 1f : 0f,
            rotateAroundZ ? 1f : 0f
        );

        if (rotationAxis == Vector3.zero)
            return;

        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
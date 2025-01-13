using UnityEngine;

public class ahihi : MonoBehaviour
{
    private BoxCollider boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // L?y ?i?m va ch?m t? ??i t??ng khác
            Vector3 collisionPoint = other.ClosestPoint(transform.position);

            // Tính toán m?t va ch?m
            string face = DetectFace(collisionPoint);
            Debug.Log($"Va ch?m v?i m?t: {face}");
        }
    }

    private string DetectFace(Vector3 collisionPoint)
    {
        // Chuy?n ?i?m va ch?m sang t?a ?? c?c b? c?a BoxCollider
        Vector3 localPoint = transform.InverseTransformPoint(collisionPoint);

        // L?y kích th??c c?a BoxCollider
        Vector3 extents = boxCollider.size / 2f;

        // So sánh ?i?m c?c b? v?i các m?t
        if (Mathf.Approximately(localPoint.x, extents.x)) return "Right";
        if (Mathf.Approximately(localPoint.x, -extents.x)) return "Left";
        if (Mathf.Approximately(localPoint.y, extents.y)) return "Top";
        if (Mathf.Approximately(localPoint.y, -extents.y)) return "Bottom";
        if (Mathf.Approximately(localPoint.z, extents.z)) return "Front";
        if (Mathf.Approximately(localPoint.z, -extents.z)) return "Back";

        return "Unknown";
    }
}

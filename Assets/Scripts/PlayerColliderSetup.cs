using UnityEngine;

public class PlayerColliderSetup : MonoBehaviour
{
    private CapsuleCollider capsuleCollider;
    private Rigidbody rb;

    void Start()
    {
        // Adding Capsule Collider
        capsuleCollider = gameObject.AddComponent<CapsuleCollider>();
        capsuleCollider.center = new Vector3(0, 1, 0); // Adjust based on player height
        capsuleCollider.height = 2; // Adjust based on player height
        capsuleCollider.radius = 0.5f; // Adjust based on player width

        // Adding Rigidbody
        rb = gameObject.AddComponent<Rigidbody>();
        rb.isKinematic = true; // If you are controlling movement via scripts
    }
}

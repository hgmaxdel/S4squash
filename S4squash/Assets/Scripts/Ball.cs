using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Ball : MonoBehaviour
{
    private Vector3 startPosition;
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    [SerializeField] private float outOfBoundsY = -10f;

    void Start()
    {
        startPosition = transform.position;

        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        // Don't let gravity affect the object initially
        rb.useGravity = false;

        // Listen for the player grabbing it
        grabInteractable.selectEntered.AddListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        // Object has been picked up for the first time
        rb.useGravity = true;
    }

    void Update()
    {
        if (transform.position.y < outOfBoundsY)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = startPosition;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Disable gravity again after respawning
        rb.useGravity = false;
    }

    void OnDestroy()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrab);
    }
}

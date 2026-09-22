using UnityEngine;
using UnityEngine.Audio;    
using UnityEngine.XR.Interaction.Toolkit;

public class Ball : MonoBehaviour
{
    private Vector3 startPosition;
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    [SerializeField] private float outOfBoundsY = -10f;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hitSound;

    void Start()
    {
        startPosition = transform.position;

        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        // Don't let gravity affect the object initially
        rb.useGravity = false;
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


        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Disable gravity again after respawning
        rb.useGravity = false;
        rb.isKinematic = true;
        rb.position = startPosition;
        rb.isKinematic = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (audioSource != null && hitSound != null)
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}
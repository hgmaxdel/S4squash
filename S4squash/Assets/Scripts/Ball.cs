using UnityEngine;
using UnityEngine.Audio;    
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Ball : MonoBehaviour
{
    private Vector3 startPosition;
    private Rigidbody rb;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;
    private bool respawned;

    [SerializeField] private float outOfBoundsY = -10f;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hitSound;

    void Start()
    {
        startPosition = transform.position;

        rb = GetComponent<Rigidbody>();
        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnSelectEntered);

        // Ball frozen in air
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    void OnSelectEntered(SelectEnterEventArgs args)
    {
        rb.constraints = RigidbodyConstraints.None;
        grabInteractable.selectEntered.RemoveListener(OnSelectEntered);
    }

    void Update()
    {
        if (respawned)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            respawned = false;
        }

        if (transform.position.y < outOfBoundsY)
        {
            Respawn();
        }
    }

    void Respawn()
    {


        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Freeze ball again after respawning
        rb.isKinematic = true;
        rb.position = startPosition;
        rb.isKinematic = false;
        respawned = true;
        grabInteractable.selectEntered.AddListener(OnSelectEntered);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (audioSource != null && hitSound != null)
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}
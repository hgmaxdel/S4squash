using UnityEngine;

public class Racket : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip swingSound;
    [SerializeField] private float swingSpeedThreshold = 1.5f;
    [SerializeField] private float swingCooldown = 0.3f;

    private Vector3 lastPosition;
    private float cooldownTimer;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        float speed = (transform.position - lastPosition).magnitude / Time.deltaTime;
        lastPosition = transform.position;

        cooldownTimer -= Time.deltaTime;

        if (speed > swingSpeedThreshold && cooldownTimer <= 0f)
        {
            PlaySwingSound();
            cooldownTimer = swingCooldown;
        }
    }

    private void PlaySwingSound()
    {
        if (audioSource != null && swingSound != null)
        {
            audioSource.PlayOneShot(swingSound);
        }
    }
}
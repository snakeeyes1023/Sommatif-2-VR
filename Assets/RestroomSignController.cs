using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestroomSignController : MonoBehaviour
{
    public AnimationClip Clip360;

    private AudioSource audioSource;
    private Animation animationController;

    void Start()
    {
        animationController = GetComponent<Animation>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "basket")
        {
            PlayAnimation();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayAnimation();
        }
    }

    void PlayAnimation()
    {
        animationController.clip = Clip360;
        animationController.Play();
        audioSource.Play();
    }
}

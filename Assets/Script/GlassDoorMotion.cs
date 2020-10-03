using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorMotion : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera") || other.CompareTag("Human"))
        {
            animator.SetTrigger("GlassOpen");
            isOpen = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            animator.SetTrigger("GlassClose");
            isOpen = false;
        }
    }
}

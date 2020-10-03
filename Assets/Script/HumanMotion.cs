using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMotion : MonoBehaviour
{
    public float _speed;
    public float _angularSpeed;
    float _hMove,_vMove;
    CharacterController cController;
    public Animation animation;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _speed = SliderScript.speedLevel;
        _angularSpeed = 100f;
        cController = GetComponent<CharacterController>();
        animation = GetComponent<Animation>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _speed = 5f;
        //if key was pressed
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            _hMove = Input.GetAxis("Horizontal") * _angularSpeed * Time.deltaTime;
            _vMove = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
            //animation.Play("BasicMotions@Walk01");
            transform.Rotate(0, _hMove, 0);
            //transform.Translate(Vector3.forward*_vMove);
            cController.Move(transform.TransformDirection(Vector3.forward * _vMove));
            transform.position.Set(0, transform.position.y, 0);
            if(!audioSource.isPlaying)
            audioSource.Play();
        }
        else if (Input.GetButton("Jump"))
        {
            //animation.Play("BasicMotions@Jump01");
        }
    }
}

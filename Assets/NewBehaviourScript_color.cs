using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript_color : MonoBehaviour
{
    public static int countt;
    Animator _animator;
	// Use this for initialization
	void Start () {
	
		_animator = GetComponent<Animator>();
        _animator.SetBool("going", false);
        int countt = 0;
	}
 
	void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            _animator.Play("anim");
            countt += 1;
        }
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetAnimation : MonoBehaviour
{
    Animator anim;
    public float offset;
    public string animationName;

    void Start()
    {
        anim = GetComponent<Animator>();

        anim.Play(animationName, 0, offset);
    }
}

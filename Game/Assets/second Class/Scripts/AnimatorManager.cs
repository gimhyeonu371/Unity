using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator Animator;

    public void run()
    {
        // SetTrigger("Run") : parameter ���ǿ� �ִ� Trigger �ߵ��ϴ� �Լ��Դϴ�.
        Animator.SetTrigger("Run");
    }
}

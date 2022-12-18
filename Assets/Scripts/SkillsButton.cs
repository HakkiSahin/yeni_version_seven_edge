using UnityEngine;

public class SkillsButton : MonoBehaviour
{
    public Animator animator;

    public void PlayTriggerAnim(string name)
    {
        animator.SetTrigger(name);
    }
}
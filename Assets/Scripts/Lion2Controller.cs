using UnityEngine;

public class Lion2Controller : MonoBehaviour
{
    public SkillButtons skillButtons;

    private Animator animator;
    private bool isRGB = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ShowSKillButtons()
    {
        var canvas = FindObjectOfType<Canvas>();
        skillButtons = Instantiate(skillButtons, canvas.transform);
        skillButtons.RegisterSkills(this);
    }

    public void HideSkillButtons()
    {
        Destroy(skillButtons.gameObject);
    }

    public void DoSkill(int skillIndex)
    {
        switch (skillIndex)
        {
            case 0:
                animator.SetTrigger("Spin");
                break;
            case 1:
                animator.SetTrigger("Fade");
                break;
            case 2:
                animator.SetBool("RGB", !isRGB);
                isRGB = !isRGB;
                break;
            default:
                break;
        }

        ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButtons : MonoBehaviour
{
    public List<Button> skillButtons;

    public void RegisterSkills(Lion2Controller controller)
    {
        foreach (var skillButton in skillButtons)
        {
            skillButton.onClick.AddListener(() =>
            {
                controller.DoSkill(skillButtons.IndexOf(skillButton));
            });
        }
    }
}

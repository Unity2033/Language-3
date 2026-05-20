using UnityEngine;

public class Axe : MonoBehaviour
{
    public int strikes;
    public float proficiency;

    public void Attack(int count)
    {
        strikes += count;

        if (strikes % 10 == 0)
        {
            Debug.Log("Critical...");
        }
    }

    public void Throw(float experience)
    {
        if(proficiency < 100)
        {
            proficiency += experience;

            Debug.Log("Proficiency : " + proficiency + "%");
        }
        else
        {
            Debug.Log("I have Mastered the skill");
        }
    }
}

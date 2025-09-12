using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Orc : MeleeEnemy
    {
        public int rageLevel;

        public Orc()
        {
            name = "Orc";
            rageLevel = 0;
        }

        public void Enrage()
        {
            rageLevel++;
            damage += 5;
            Debug.Log($"{name} enrages! Rage level: {rageLevel}, damage now {damage}");
        }
    }
}

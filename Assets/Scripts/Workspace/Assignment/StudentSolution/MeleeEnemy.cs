using UnityEngine;

namespace Assignment.StudentSolution
{
    public class MeleeEnemy : Enemy
    {
        public int strength;

        public MeleeEnemy()
        {
            name = "MeleeEnemy";
            strength = 10;
        }

        public override void Attack(Entity target)
        {
            int totalDamage = damage + strength;
            Debug.Log($"{name} (melee) attacks {target?.name ?? "null"} for {totalDamage} damage (damage {damage}, strength {strength})");
        }
    }
}

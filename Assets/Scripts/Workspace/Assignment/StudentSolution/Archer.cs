using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Archer : RangeEnemy
    {
        public int accuracy;

        public Archer()
        {
            name = "Archer";
            accuracy = 75;
        }

        public override void Attack(Entity target)
        {
            Debug.Log($"{name} aims and attacks {target?.name ?? "null"} with accuracy {accuracy}, damage {damage}");
            AimAndShoot(target);
        }

        public void AimAndShoot(Entity target)
        {
            Debug.Log($"{name} AimAndShoot at {target?.name ?? "null"}");
        }
    }
}

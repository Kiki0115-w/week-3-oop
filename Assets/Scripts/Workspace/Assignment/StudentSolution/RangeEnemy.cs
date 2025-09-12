using UnityEngine;

namespace Assignment.StudentSolution
{
    public class RangeEnemy : Enemy
    {
        public int range;

        public RangeEnemy()
        {
            name = "RangeEnemy";
            range = 5;
        }

        public override void Attack(Entity target)
        {
            Debug.Log($"{name} (range) attacks {target?.name ?? "null"} from range {range} for {damage} damage");
        }
    }
}

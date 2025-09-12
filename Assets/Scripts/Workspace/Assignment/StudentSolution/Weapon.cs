using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Weapon : Equipment
    {
        public int attackPower;

        public Weapon()
        {
            name = "Weapon";
            attackPower = 5;
        }

        public virtual void DealDamage(Entity target)
        {
            Debug.Log($"{name} deals {attackPower} damage to {target?.name ?? "null"}");
        }
    }
}

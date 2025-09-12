using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana;

        public Mage()
        {
            name = "Mage";
            mana = 50;
        }

        public override void Attack(Entity target)
        {
            if (mana <= 0)
            {
                Debug.Log($"{name} has no mana to attack");
                return;
            }
            mana -= 10;
            Debug.Log($"{name} casts magic attack on {target?.name ?? "null"}, remaining mana {mana}");
            CastSpell(target);
        }

        public void CastSpell(Entity target)
        {
            Debug.Log($"{name} CastSpell on {target?.name ?? "null"}");
        }
    }
}

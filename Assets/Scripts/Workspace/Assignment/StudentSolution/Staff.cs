using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;

        public Staff()
        {
            name = "Staff";
            magicPower = 20;
            attackPower = 6;
        }

        public void CastSpell()
        {
            Debug.Log($"{name} CastSpell with power {magicPower}");
        }

        public override void Equip(Player player)
        {
            Debug.Log($"{name} (staff) equipped by {player?.name ?? "null"}");
        }

        public override void DealDamage(Entity target)
        {
            Debug.Log($"{name} (staff) deals {attackPower} magic damage to {target?.name ?? "null"}");
        }
    }
}

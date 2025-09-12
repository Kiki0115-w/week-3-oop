using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Bow : Weapon
    {
        public int range;

        public Bow()
        {
            name = "Bow";
            range = 50;
            attackPower = 8;
        }

        public void Shoot()
        {
            Debug.Log($"{name} Shoot with range {range}");
        }

        public override void Equip(Player player)
        {
            Debug.Log($"{name} (bow) equipped by {player?.name ?? "null"}");
        }

        public override void DealDamage(Entity target)
        {
            Debug.Log($"{name} (bow) deals {attackPower} damage to {target?.name ?? "null"}");
        }
    }
}

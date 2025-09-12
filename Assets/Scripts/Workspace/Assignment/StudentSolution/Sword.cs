using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public Sword()
        {
            name = "Sword";
            bladeLength = 30;
            attackPower = 10;
        }

        public void Slash()
        {
            Debug.Log($"{name} Slash with blade length {bladeLength}");
        }

        public override void Equip(Player player)
        {
            Debug.Log($"{name} (sword) equipped by {player?.name ?? "null"}");
        }

        public override void DealDamage(Entity target)
        {
            Debug.Log($"{name} (sword) deals {attackPower} damage to {target?.name ?? "null"}");
        }
    }

}

using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Potion : Item
    {
        public int healingAmount;

        public Potion()
        {
            name = "Potion";
            healingAmount = 20;
        }

        public override void Use(Player player)
        {
            Debug.Log($"{name} used by {player?.name ?? "null"}, healing {healingAmount}");
        }
    }
}

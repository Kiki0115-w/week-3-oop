using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Armor : Equipment
    {
        public int defense;

        public Armor()
        {
            name = "Armor";
            defense = 5;
        }

        public override void Equip(Player player)
        {
            Debug.Log($"{name} (armor) equipped by {player?.name ?? "null"}, defense {defense}");
        }
    }
}

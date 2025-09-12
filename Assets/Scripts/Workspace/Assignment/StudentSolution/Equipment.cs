using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Equipment : Item
    {
        public Equipment()
        {
            name = "Equipment";
        }

        public virtual void Equip(Player player)
        {
            Debug.Log($"{name} equipped by {player?.name ?? "null"}");
        }
    }
}

using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Item
    {
        public string name;
        private int value;

        public Item()
        {
            name = "Item";
            value = 0;
        }

        public virtual void Use(Player player)
        {
            Debug.Log($"{name} used by {player?.name ?? "null"}");
        }
    }
}

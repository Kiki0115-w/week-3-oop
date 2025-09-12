using UnityEngine;

namespace Assignment.StudentSolution
{
    public class NPC : Entity
    {
        public string dialogue;
        private bool isFriendly;

        public NPC()
        {
            name = "NPC";
            dialogue = "Hello!";
            isFriendly = true;
        }

        public virtual void Interact(Player player)
        {
            Debug.Log($"{name} interacts with {player?.name ?? "null"}: {dialogue}");
        }
    }
}

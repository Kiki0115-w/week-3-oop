using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Troll : MeleeEnemy
    {
        public int regenerationRate;

        public Troll()
        {
            name = "Troll";
            regenerationRate = 5;
        }

        public void Regenerate()
        {
            health += regenerationRate;
            Debug.Log($"{name} regenerates {regenerationRate}, health now {health}");
        }
    }
}

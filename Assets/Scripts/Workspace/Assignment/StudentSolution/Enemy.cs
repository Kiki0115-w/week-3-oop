using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage;
        protected int aiLevel;

        public Enemy()
        {
            damage = 10;
            aiLevel = 1;
            name = "Enemy";
        }

        public virtual void Attack(Entity target)
        {
            if (target == null) return;
            Debug.Log($"{name} attacks {target.name} for {damage} damage");
        }

        protected virtual void Patrol()
        {
            Debug.Log($"{name} is patrolling with AI level {aiLevel}");
        }
    }
}

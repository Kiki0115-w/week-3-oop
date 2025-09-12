using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Entity
    {
        public string name;
        private Vector3 position;
        protected int health;

        public Entity()
        {
            name = "Entity";
            position = Vector3.zero;
            health = 100;
        }

        public virtual void Update()
        {
            Debug.Log($"{name} Update called");
        }

        protected virtual void TakeDamage(int damage)
        {
            health -= damage;
            if (health < 0) health = 0;
            Debug.Log($"{name} took {damage} damage, health now {health}");
        }

        private void Move(Vector3 direction)
        {
            position += direction;
            Debug.Log($"{name} moved to {position}");
        }
    }
}

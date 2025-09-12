using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items;

        public Player()
        {
            score = 0;
            items = new Item[0];
            name = "Player";
        }

        public void CollectItem(Item item)
        {
            if (item == null) return;
           
            Item[] newItems = new Item[items.Length + 1];
            for (int i = 0; i < items.Length; i++) newItems[i] = items[i];
            newItems[newItems.Length - 1] = item;
            items = newItems;
            Debug.Log($"{name} collected item {item.name}");
        }

        protected void LevelUp()
        {
            score += 100;
            Debug.Log($"{name} leveled up! Score: {score}");
        }
    }
}

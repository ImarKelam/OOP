using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Mage : Character, IAttack
    {
        public Mage(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = 300;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            // with this the output is as in the example
            //var target = targetsList.LastOrDefault(t => t.Team != this.Team && t.IsAlive);


            // I think this is the correct though, because the "mage always picks the last target" 
            // I think this means the one furthest from him and to check which one is furthest, we have to calculate the distance to each target and pick the last one
            var target = targetsList
                .Where(t => t.Team != this.Team && t.IsAlive)
                .OrderBy(t => Math.Sqrt(
                        (this.X - t.X) * (this.X - t.X) +
                        (this.Y - t.Y) * (this.Y - t.Y)
                        ))
                .LastOrDefault();

            return target; ;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public int AttackPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}

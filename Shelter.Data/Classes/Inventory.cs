using System;
namespace Shelter.Data.Classes
{
    public class Inventory
    {
        /// <summary>
        /// ID prop. Cant be null
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name prop. Cant be null
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price prop. Cant be null
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Quantity prop. Cant be null
        /// </summary>
        public int Quantity { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuManager
{
    /// <summary>
    /// Enum declared for categories of food item
    /// </summary>
    public enum CategoryOfFood
    {
        Daal,
        Enter,
        Rice,
        Paratha,
        Dessert,
        Raita
    };
    public class MenuItem
    {
        /// <summary>
        /// Id of MenuItem
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Property for name of the food item
        /// </summary>
        public string Name { get; set; }
        public CategoryOfFood Category { get; set; }
        public virtual ICollection<MenuDate> Dates { get; set; }
        public MenuItem()
        {
            Dates = new List<MenuDate>();
        }
       
    }
}

using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }
        public Cart()
        {
            Items = new Dictionary<int, CartItem>();
        }

        /// <summary>
        /// Количество объектов в корзине
        /// </summary>
        public int Count
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity);
            }
        }

        /// <summary>
        /// Количество калорий
        /// </summary>
        public int Calories
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity * item.Value.Dish.Calories);
            }
        }

        /// <summary>
        /// Добавление в корзину
        /// </summary>
        /// <param name="dish">добавляемый объект</param>
        public virtual void AddToCart(Dish dish)
        {
            // если объект есть в корзине
            // то увеличить количество
            if (Items.ContainsKey(dish.DishId))
                Items[dish.DishId].Quantity++;
            // иначе - добавить объект в корзину
            else
                Items.Add(dish.DishId, new CartItem
                {
                    Dish = dish,
                    Quantity = 1
                });
        }

        /// <summary>
        /// Удалить объект из корзины
        /// </summary>
        /// <param name="id">id удаляемого объекта</param>
        public virtual void RemoveFromCart(int id)
        {
            Items.Remove(id);
        }

        /// <summary>
        /// Очистить корзину
        /// </summary>
        public virtual void ClearAll()
        {
            Items.Clear();
        }
    }

    /// <summary>
    /// Клас описывает одну позицию в корзине
    /// </summary>
    public class CartItem
    {
        public Dish Dish { get; set; }
        public int Quantity { get; set; }
    }

}

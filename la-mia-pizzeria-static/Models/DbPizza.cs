using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Models
{
    public class DbPizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=pizzabase;Integrated Security=True;encrypt=false");
        }


        public void seed()
        {
            if (!Pizzas.Any())
            {
                var seed = new Pizza[]
                {
                        new Pizza {
                            Name = "Margherita",
                            Description = "abcd",
                            Image  = "https://picsum.photos/id/292/100/100",
                            Price ="7€"
                        },

                        new Pizza {
                            Name = "Marinara",
                            Description = "abcd",
                            Image  = "https://picsum.photos/id/292/100/100",
                            Price ="5€"
                        }
                };
                Pizzas.AddRange(seed);
                SaveChanges();
            }
        }
    }
}


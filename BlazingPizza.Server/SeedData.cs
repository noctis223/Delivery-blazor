namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var toppings = new Topping[]
        {
            new Topping()
            {
                    Name = "Formaggio extra",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "Bacon americano",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Bacon britannico",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Bacon canadese",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Tè e biscotti",
                    Price = 5.00m
            },
            new Topping()
            {
                    Name = "Scones appena sfornati",
                    Price = 4.50m,
            },
            new Topping()
            {
                    Name = "Peperoni",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Cipolle",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Funghi",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Salsiccia di anatra",
                    Price = 3.20m,
            },
            new Topping()
            {
                    Name = "Polpette di cervo",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "Servito su un vassoio d'argento",
                    Price = 250.99m,
            },
            new Topping()
            {
                    Name = "Aragosta sopra",
                    Price = 64.50m,
            },
            new Topping()
            {
                    Name = "Uova di storione",
                    Price = 101.75m,
            },
            new Topping()
            {
                    Name = "Carciofi",
                    Price = 3.40m,
            },
            new Topping()
            {
                    Name = "Pomodori freschi",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Basilico",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Bistecca (cottura media-rara)",
                    Price = 8.50m,
            },
            new Topping()
            {
                    Name = "Peperoncini ardenti",
                    Price = 4.20m,
            },
            new Topping()
            {
                    Name = "Pollo alla buffalo",
                    Price = 5.00m,
            },
            new Topping()
            {
                    Name = "Formaggio blu",
                    Price = 2.50m,
            },
        };

        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                    Name = "Pizza al Formaggio Base",
                    Description = "È piena di formaggio ed è deliziosa. Perché non vorresti averne una?",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Il Baconatorizor",
                    Description = "Ha OGNI tipo di bacon",
                    BasePrice = 11.99m,
                    ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Pepperoni Classico",
                    Description = "È la pizza con cui sei cresciuto, ma con peperoncini ardenti!",
                    BasePrice = 10.50m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Pollo alla buffalo",
                    Description = "Pollo speziato, salsa piccante e formaggio blu, garantito per riscaldarti",
                    BasePrice = 12.75m,
                    ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Amanti dei Funghi",
                    Description = "Ha funghi. Non è ovvio?",
                    BasePrice = 11.00m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Il Brit",
                    Description = "Quando sei a Londra...",
                    BasePrice = 10.25m,
                    ImageUrl = "img/pizzas/brit.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Delizia Vegana",
                    Description = "È come un'insalata, ma su una pizza",
                    BasePrice = 11.50m,
                    ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                    Name = "Margherita",
                    Description = "Pizza italiana tradizionale con pomodori e basilico",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/margherita.jpg",
            },
        };

        db.Toppings.AddRange(toppings);
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}

using db_vegetables_and_fruits.Services;
VegFruitServices VegFruitService = new VegFruitService();
VegFruitService.AddFruit(new VegFruitServices.Models.VegFruit() { Name = "яблоко", Type = "фрукт", Color = "зеленый", Сalorie_content = 200 });
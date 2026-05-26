namespace DesignPatterns.CompositePattern
{
    public class CompositePatternTestDrive : TestDrive
    {
        public static void test()
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            dinerMenu.add(dessertMenu);

            dinerMenu.add(new MenuItem("Diner Item1", "Diner Description 1", vegetarian: true, 5.6));
            dinerMenu.add(new MenuItem("Diner Item2", "Diner Description 2", vegetarian: false, 7.0));
            dinerMenu.add(new MenuItem("Diner Item3", "Diner Description 3", vegetarian: true, 4.2));
            dinerMenu.add(new MenuItem("Diner Item4", "Diner Description 4", vegetarian: false, 8.1));
            dinerMenu.add(new MenuItem("Diner Item5", "Diner Description 5", vegetarian: true, 5.7));

            pancakeHouseMenu.add(new MenuItem("Pancake Item1", "Pancake Description 1", vegetarian: true, 2.9));
            pancakeHouseMenu.add(new MenuItem("Pancake Item2", "Pancake Description 2", vegetarian: true, 1.9));
            pancakeHouseMenu.add(new MenuItem("Pancake Item3", "Pancake Description 3", vegetarian: false, 4.3));
            pancakeHouseMenu.add(new MenuItem("Pancake Item4", "Pancake Description 4", vegetarian: true, 4.1));
            pancakeHouseMenu.add(new MenuItem("Pancake Item5", "Pancake Description 5", vegetarian: false, 3.0));

            dessertMenu.add(new MenuItem("dessert Item1", "dessert Description 1", vegetarian: true, 5.6));
            dessertMenu.add(new MenuItem("dessert Item2", "dessert Description 2", vegetarian: true, 7.0));
            dessertMenu.add(new MenuItem("dessert Item3", "dessert Description 3", vegetarian: false, 4.2));
            dessertMenu.add(new MenuItem("dessert Item4", "dessert Description 4", vegetarian: true, 8.1));


            Waitress waitress = new Waitress(allMenus);
            waitress.print();
        }
    }
}
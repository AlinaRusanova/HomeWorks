using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine
{
    class ConsoleForClient
    {
        public static void Print()
        {
            Console.WriteLine("Hello! Below you can see our List of Wine and choose perfect for you");

            WineStorage.WineList();
        }


        public static List<Wine> ShowAll()
        {
            var allWineList = WineStorage.WineList();

            Console.WriteLine($"We can offer to you such bottle as: ");

            foreach (Wine item in allWineList)
            {
               Console.WriteLine($"{item._ID}. Color: {item.WineColor}, type: {item.WineType}, strength {item.WineStrength}");
            }

            return allWineList;
        }


        public static List<Wine> ChooseType(WineType type)
        {
            var selectedType = WineStorage.WineList().Where(wb => wb.WineType == type).ToList();

            Console.WriteLine($"We can offer to you such bottle as: ");

            foreach (Wine item in selectedType)
            {
                Console.WriteLine($"{item._ID}. Color: {item.WineColor}, type: {item.WineType}, strength {item.WineStrength}");
            }

            return selectedType;
        }




        public static List<Wine> ChooseColor(WineColor color)
        {
            var selectedColor =  WineStorage.WineList().Where(wb => wb.WineColor == color).ToList();

            Console.WriteLine($"We can offer to you such bottle as: ");

            foreach (Wine item in selectedColor)
            {
                Console.WriteLine($"{item._ID}. Color: {item.WineColor}, type: {item.WineType}, strength {item.WineStrength}");
            }

            return selectedColor;
        }

        public static List<Wine> FullChoosen  (WineColor color, WineType type, int year, int strength)
        {
            var selectedAll = WineStorage.WineList().Where(wb => wb.WineColor == color && wb.WineType == type && wb.WineYearOfProduction == year && wb.WineStrength == strength).ToList();

            Console.WriteLine($"We can offer to you such bottle as: ");

            foreach (Wine item in selectedAll)
            {
                Console.WriteLine($"{item._ID}. Color: {item.WineColor}, type: {item.WineType}, strength {item.WineStrength}");
            }

            return selectedAll;
        }

        public static List<Wine> SortByYear()
        {
            var selectedAll = WineStorage.WineList().OrderBy(wb => wb.WineYearOfProduction).ToList();

            Console.WriteLine($"We can offer to you such bottle as: ");

            foreach (Wine item in selectedAll)
            {
                Console.WriteLine($"{item._ID}. Year: {item.WineYearOfProduction}, color: {item.WineColor}, type: {item.WineType}, strength {item.WineStrength}");
            }

            return selectedAll;
        }

        public static List<Wine> SortByStrenght()
        {
            var selectedAll = WineStorage.WineList().OrderBy(wb => wb.WineStrength).ToList();

            Console.WriteLine($"We can offer to you such bottle as: ");

            foreach (Wine item in selectedAll)
            {
                Console.WriteLine($"{item._ID}. Year: {item.WineYearOfProduction}, color: {item.WineColor}, type: {item.WineType}, strength {item.WineStrength}");
            }

            return selectedAll;
        }


        public static void Final()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome to 'World of Wine shop! Please choose how would you want to chek WineList: \n" +
                $"\t 1. All Wine list \n" +
                $" \t 2. Choose color \n" +
                $" \t 3. Choose type \n" +
          //      $" \t 4. Choose color,type,year of production and strenght \n" +
                $" \t 4. Sort by year \n" +
                $" \t 5. Sort by strength \n");

            Console.ResetColor();

          //  string answer = Console.ReadLine();

            try
            {
                switch (Console.ReadLine()?.ToLower())
                {
                    case "1":
                    case "1.":
                    case "All":
                    case "1. All Wine list":
                    case "All Wine list":
                        ShowAll();
                        Console.WriteLine("Would you like to order?");
                        break;

                    case "2":
                    case "2.":
                    case "Color":
                    case "2. Choose color":
                    case "Wine color":
                    case "color of wine":
                    case "choose color":


                        Console.WriteLine("We have such color of wine:");


                        //for (int i = 0; i < Enum.GetNames(typeof(WineColor)).Length; i++)
                        //{
                        //    Console.WriteLine($"{i}. {i.GetType}");
                        //}

                        foreach (var item in Enum.GetNames(typeof(WineColor)))
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("What do you prefer?");
                        //  string a = Console.ReadLine();
                        //  WineColor b = Enum.TryParse(typeof(WineColor),a,);    // доработать

                        switch (Console.ReadLine()?.ToLower())
                        {
                            case "rose":
                            case "2":
                                ChooseColor(WineColor.Rose);
                                break;
                            case "red":
                            case "3":
                                ChooseColor(WineColor.Red);
                                break;
                            case "white":
                            case "1":
                                ChooseColor(WineColor.Red);
                                break;
                        }
                        Console.WriteLine("Would you like to order?");
                        break;


                    case "3":
                    case "3.":
                    case "Type":
                    case "3. Choose type":
                    case "Wine type":
                    case "type of wine":
                    case "Choose type":

                        Console.WriteLine("We have such color of wine:");


                        foreach (var item in Enum.GetNames(typeof(WineType)))
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("What do you prefer?");
                        

                        switch (Console.ReadLine()?.ToLower())
                        {
                            case "Dry":
                            case "2":
                                ChooseType(WineType.Dry);
                                break;
                            case "semisweet":
                            case "3":
                                ChooseType(WineType.Semisweet);
                                break;
                            case "white":
                            case "1":
                                ChooseType(WineType.Sweet);
                                break;
                        }
                        Console.WriteLine("Would you like to order?");
                        break;
                     


                    //case "4":
                    //case "4.":
                    //case "4. Choose color,type,year of production and strenght":
                    //case "Choose color,type,year of production and strenght":
                    //case "choose all":
                    //case "custom choose":
                    //case "all choose":

                    //    FullChoosen(WineColor.White,WineType.Sweet,1995,8);  // доработать
                    //    break;

                    case "4":
                    case "4.":
                    case "4. Sort by year ":
                    case "Sort by year ":
                    case "Sortbyyear ":                  

                        SortByYear();
                        Console.WriteLine("Would you like to order?");
                        break;


                    case "5":
                    case "5.":
                    case "5. Sort by strenght":
                    case "Sort by strenght":
                    case "Sortbystrenght":

                        SortByStrenght();
                        Console.WriteLine("Would you like to order?");
                        break;

                    default: Console.WriteLine("Please do your choose");
                        break;

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Something unexpected happen");
                Console.WriteLine(ex.Message);
            }


        }



    }
}

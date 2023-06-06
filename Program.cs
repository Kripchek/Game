namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Inventory> inventory = new List<Inventory>()
            {
                new("chto-to1", 7),
                new("chto-to2", 5),
                new("chto-to3", 9),
                new("chto-to4", 1),
                new("chto-to5", 1),
                new("chto-to6", 1),
                new("chto-to7", 2),
                new("chto-to8", 1),
            };

            Battle battle = new Battle();
            battle.Battlechek();

            void Test1()
            {
                Console.WriteLine("список ваших предметов");
                foreach (var invent in inventory)
                {
                    Console.WriteLine($"{invent._id}, {invent.Name}, {invent.Count}");
                }
            }

            void TestAddItem(string item, int amount)
            {
                Console.WriteLine($"вам выпал {item} в количестве {amount}. вы хотите его добавить в свой инвентарь? (Y)es/(N)o");
                string choiseadditem = Console.ReadLine();
                if (choiseadditem == "Y" || choiseadditem == "y" || choiseadditem == "У" || choiseadditem == "у")
                {
                    if (inventory.Count < inventory.Capacity)
                    {
                        inventory.Add(new(item, amount));
                    }
                    else
                    {
                        Console.WriteLine("у вас нет места в инвентаре");
                    }
                }
                else if (choiseadditem == "N" || choiseadditem == "n")
                {
                    Console.WriteLine("Правильно, нахер этот предмет нужен :3");
                }
            }

            void Test2()
            {
                Console.WriteLine("напишите номер предмета(id) который вы хотите выкинуть:");
                int x = int.Parse(Console.ReadLine());
                foreach (var invent in inventory)
                {
                    if (invent._id == x)
                    {
                        Console.WriteLine("вы хотите выкинуть все предметы(dropall) или только один(drop)");
                        string choisedrop = Console.ReadLine();
                        if (choisedrop == "dropall")
                        {
                            inventory.Remove(invent);
                            break;
                        }
                        else if (choisedrop == "drop")
                        {
                            invent.Count -= 1;
                            break;
                        }
                    }
                }
            }
        }
    }
}
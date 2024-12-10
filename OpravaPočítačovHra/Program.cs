using static System.Formats.Asn1.AsnWriter;

namespace OpravaPočítačovHra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> store = new List<string>();
            List<string> grafiky = new List<string>();
            int cena = 188;
            int cena2 = 100;
            int cena3 = 70;
            int cena4 = 150;
            grafiky.Add("Geforce gt 1030 OC 2G");
            grafiky.Add("GTX 1650 4G");
            grafiky.Add("GTX 1080 8G ");
            grafiky.Add("RTX 3050 6G");

            bool isEnd = false;
            while (!isEnd)
            {
                PrintMenu();
                var answer = Console.ReadLine();


                switch (answer)
                {
                    case "1":
                        foreach (var item in store)
                        {
                            Console.WriteLine(grafiky);
                        }
                        break;
                        


                    case "2":
                        Console.WriteLine("Zadajte meno noveho predmetu:");
                        var newItemName = Console.ReadLine();
                        Console.WriteLine("Zadajte kolko kusov noveho predmetu:");
                        var newItemCount = Console.ReadLine();
                        AddItem(store, newItemName, int.Parse(newItemCount));
                        break;



                    case "3":
                        

                    default:
                        {
                            Console.WriteLine("Nespravna akcia!");
                            break;
                        }

                }
            }



        }
        public static void AddItem(List<string> itemList, string itemName, int itemCount)
        {
            string foundedItem = null;
            foreach (var item in itemList)
            {
                if (item.Contains(itemName))
                {
                    foundedItem = item;
                }
            }
            if (foundedItem == null)
            {
                var newCreatedItem = $"{itemName}||{itemCount}";
                itemList.Add(newCreatedItem);
                Console.WriteLine($"Predmet {itemName.ToUpper()} bol pridany do obchodu");
            }
            else
            {
                var splittedItem = foundedItem.Split();
                var foundedItemName = splittedItem[0];
                var foundedItemCount = int.Parse(splittedItem[1]);
                var newItemCount = foundedItemCount + itemCount;

                var indexOfItem = foundedItem.IndexOf(foundedItem);
                itemList[indexOfItem] = $"{itemName}||{newItemCount}";
                Console.WriteLine($"Predmet {foundedItemName.ToUpper()} bol zaktualizovany do obchodu");

            }

        }
        public static void PrintMenu()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("1.Obchod z komponentami");
            Console.WriteLine("2.Kupit komponent");
            Console.WriteLine("3.Opravit PC");
            Console.Write("Vyberte akciu:");
        }
    }
}
    
    

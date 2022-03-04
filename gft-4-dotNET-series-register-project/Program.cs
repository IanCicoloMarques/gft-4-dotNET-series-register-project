using System;
using gft_4_dotNET_series_register_project.Classes;
using gft_4_dotNET_series_register_project.Enum;

namespace gft_4_dotNET_series_register_project
{
    class Program
    {
        private static StreamRepository repository = new StreamRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListStreams();
                        break;
                    
                    case "2":
                        AddStream();
                        break;
                    
                    case "3":
                        break;
                    
                    case "4":
                        break;
                    
                    case "5":
                        break;
                    
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                       throw new ArgumentOutOfRangeException();
                        
                }                
            }
        }

        private static void AddStream()
        {
            Console.WriteLine("Add new stream");

            foreach (int i in System.Enum.GetValues(typeof(Genres)))
            {
                Console.WriteLine("{0} -{1}", i, System.Enum.GetName(typeof(Genres), i));
            }

            Console.Write("Chose the genre of the stream: ");
            int inputGenre = int.Parse((Console.ReadLine()));
            
            Console.Write("Enter the stream's title: ");
            string inputTitle = Console.ReadLine();
            
            Console.Write("Enter the airing date: ");
            int inputDate = int.Parse((Console.ReadLine()));

            Console.Write("Enter the description of the stream: ");
            string inputDescription = Console.ReadLine();

            Streams newStream = new Streams(id: repository.NextId(),
                genre: (Genres) inputGenre,
                title: inputTitle,
                description: inputDescription,
                date: inputDate);
            
            repository.Insert(newStream);
        }

        private static void ListStreams()
        {
            Console.WriteLine("List streams");

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("No streams currently");
                return;
            }

            foreach (var stream in list)
            {
                Console.WriteLine("#ID {0}: - {1}", stream.ReturnId(), stream.ReturnTitle());
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Choose your option:");
    
            Console.WriteLine("1 - List streams");
            Console.WriteLine("2 - Add new stream");
            Console.WriteLine("3 - Update stream");
            Console.WriteLine("4 - Remove stream");
            Console.WriteLine("5 - Stream details");
            Console.WriteLine("C - Clean window");
            Console.WriteLine("X - Close");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return GetUserOption();
        }
        
    }
}

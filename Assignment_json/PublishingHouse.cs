namespace Assignment_json
{
    internal class PublishingHouse
    {
        private static int Id = 0;
        public readonly int _id;
        public string Name { get; set; }
        public string Address { get; set; }

        public PublishingHouse()
        {
            _id = ++Id;
        }
        public void GetInfo()
        {
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║               Інформація про видавництво               ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine($"║ Id: {_id}");
            Console.WriteLine($"║ Назва: {Name}");
            Console.WriteLine($"║ Адреса: {Address}");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
        }
    }
}

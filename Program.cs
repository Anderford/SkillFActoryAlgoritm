class Program
{
    public static void Main(string[] args)
    {
        User user1 = new User();
        user1.Login = "Login1";
        user1.Name = "Name1";
        user1.IsPremium = true;
        User user2 = new User();
        user2.Login = "Login2";
        user2.Name = "Name2";
        user2.IsPremium = false;
        User[] Users = new User[] { user1, user2 };
        SayHello(Users);
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
    static void SayHello(User[] Users)
    {
        foreach (var user in Users)
        {
            Console.WriteLine($"Hello {user.Name} {user.Login}");
            if (user.IsPremium) { }
            else { ShowAds(); }
        }
    }
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }

    
}

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Nome do Herói: ");
        string? nomedoHeroi = Console.ReadLine();

        Console.WriteLine("  ");

        Console.WriteLine("Digite o XP adquirido: ");
        int expHero = Convert.ToInt32(Console.ReadLine());
        string levelHeroi;

        if (expHero >= 5000)
        {
            levelHeroi = "Legendary";
        }

        else if (expHero >= 4000)
        {
            levelHeroi = "Professional";
        }

        else if (expHero >= 3000)
        {
            levelHeroi = "Semi-Pro";
        }

        else if (expHero >= 2000)
        {
            levelHeroi = "Amateur";
        }

        else if (expHero <= 1000)
        {
            levelHeroi = "Begginner";
        }

        else
        {
            levelHeroi = "Unranked";
        }

        Console.WriteLine($"O nome do Herói é : {nomedoHeroi} + Seu Nivel é :  {levelHeroi}");



    }
}

string especie, raca, nome, cor, idade;

        Console.WriteLine("---- Check-in Bosque las Animal ---");
        Console.Write("Digite a Espécie do animal: ");
        especie = Console.ReadLine()!;
        Console.Write("Digite a Raça: ");
        raca = Console.ReadLine()!;
        Console.Write("Digite o Nome do animal: ");
        nome = Console.ReadLine()!;
        Console.Write("Digite a Idade do animal: ");
        idade = Console.ReadLine()!;
        Console.Write("Digite a Cor do animal: ");
        cor = Console.ReadLine()!;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("+=========================================================+");
        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("               Hotel Pet \"Bosque las Animal\"             ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|");
        Console.WriteLine("+=========================================================+");

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($" Espécie: {especie.PadLeft(19, '.').Substring(0, 19)} | Raça: {raca.PadLeft(18, '.').Substring(0, 18)} ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|");

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($" Atende pela alcunha de:  {nome.PadLeft(30, '.').Substring(0, 30)} ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|");

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($" Idade: {idade.PadLeft(2, '0').Substring(0, 2)} ano(s) | Pelagem/cor: {cor.PadLeft(23, '.').Substring(0, 23)} ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|");

        Console.WriteLine("+=========================================================+");
        Console.ResetColor();

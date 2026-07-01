float mass, aceleration, force;
bool loop = true;
while (loop)
{
    Console.Clear();
    Console.WriteLine("Levando em conta a fórmula F = m * a, escolha a variável que deseja descobrir:");
    Console.WriteLine("F - 1");
    Console.WriteLine("m - 2");
    Console.WriteLine("a - 3");
    Console.WriteLine("Sair -  0");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "0":
            loop = false;
            break;
        case "1":
            Console.WriteLine("Digite o valor da massa em kg: ");
            mass = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor da aceleração em metros por segundo ao quadrado: ");
            aceleration = Convert.ToSingle(Console.ReadLine());
            force = mass * aceleration;
            Console.WriteLine($"A força será de {force} Newtons");
            break;
        case "2":
            Console.WriteLine("Digite o valor da força em Newtons: ");
            force = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor da aceleração em metros por segundo ao quadrado: ");
            aceleration = Convert.ToSingle(Console.ReadLine());
            mass = force / aceleration;
            Console.WriteLine($"A massa será de {mass}kg");
            break;
        case "3":
            Console.WriteLine("Digite o valor da força em Newtons: ");
            force = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor da massa em kg: ");
            mass = Convert.ToSingle(Console.ReadLine());
            aceleration = force / mass;
            Console.WriteLine($"A massa será de {mass}kg");
            break;
        default:
            Console.WriteLine("Essa opção não existe");
            break;
    }
    Console.ReadKey();
}


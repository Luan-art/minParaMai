char[] palavra = new char[10];

for (int i = 0; i < 10; i++)
{
    palavra[i] = char.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Vogais");

for (int i = 0; i < 10; i++)
{

    if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
    {
        switch (palavra[i])
        {
            case 'a':
                palavra[i] = 'A';
                break;
            case 'e':
                palavra[i] = 'E';
                break;
            case 'i':
                palavra[i] = 'I';
                break;
            case 'o':
                palavra[i] = 'U';
                break;
            case 'u':
                palavra[i] = 'O';
                break;
            default:
                break;
        }

    }
}

for (int i = 0; i < 10; i++)
{

    Console.WriteLine(palavra[i]);
    
}



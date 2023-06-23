string? input = "";
int[] exp;
int result = 0;
int j = 0;

Console.WriteLine("==== Conversor de binário para decimal ====");

input = Console.ReadLine();

if(string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Número binário é inválido!");
    return;
}



exp = new int[input.Length];

for(int i = 0; i < input.Length; i++)
{
    exp[i] = Convert.ToInt32(Math.Pow(2, i));
}


for (int i = (input.Length - 1); i >= 0; i--)
{
    switch (input[i].ToString())
    {
        case "1": case "0":
            break;
        default:
            Console.WriteLine("Número binário inválido!");
            return;
    }


    result += Convert.ToInt32(input[i].ToString()) * exp[j];
    j++;
}

Console.WriteLine(result.ToString());
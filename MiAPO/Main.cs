namespace MiAPO
{
    public partial class Practos
    {
        public static void Main()
        {
            float numeric1 = 0;
            float numeric2 = 0;
            char operation;

            Console.WriteLine("Введите первое число");
            numeric1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            numeric2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие: +, -, /, *");
            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Adder(numeric1, numeric2);
                    break;
                
                case '/':
                    Divider(numeric1, numeric2);
                    break;

                case '-':
                    Subtractor(numeric1, numeric2);
                    break;

                case '*':
                    Multiplier(numeric1, numeric2);
                    break;
            }

        }
    }
}

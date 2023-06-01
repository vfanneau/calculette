namespace calculette;

class Program
{
    static void Main(string[] args)
    {

        bool first = true;
        double[] input = new double[2];

        while (true)
        {

            Console.WriteLine("premier terme :");
            input[0] = Double.Parse(Console.ReadLine());

            Console.WriteLine("deuxieme terme :");
            input[1] = Double.Parse(Console.ReadLine());

            Console.WriteLine("operations disponibles :");
            Console.WriteLine("addition, soustraction, multiplication, division, reste");
            Console.WriteLine("quelle operation voulez vous effectuer ?");

            if(first){
                Console.WriteLine("PS : attention aux fautes de frappes");
            } else {
                first = false;
            }

            string operateur = Console.ReadLine();

            switch (operateur)
            {
                case "addition":
                    Console.WriteLine(input[0] + " + " + input[1] + " = " + Add(input));
                    break;

                case "soustraction":
                    Console.WriteLine(input[0] + " - " + input[1] + " = " + Substract(input));
                    break;

                case "multiplication":
                    Console.WriteLine(input[0] + " x " + input[1] + " = " + Multiply(input));
                    break;

                case "division":
                    Console.WriteLine(input[0] + " / " + input[1] + " = " + Divide(input));
                    break;

                case "modulo":
                    Console.WriteLine(input[0] + " % " + input[1] + " = " + Modulo(input));
                    break;

                default:
                    Console.WriteLine("operation indisponible : " + operateur);
                    break;
            }
        }
    }

    static double Add(double[] input){
        return input[0] + input[1];
    }

    static double Substract(double[] input){
        return input[0] - input[1];
    }

    static double Multiply(double[] input){
        return input[0] * input[1];
    }

    static double Divide(double[] input){
        return input[0] / input[1];
    }

    static double Modulo(double[] input){
        return input[0] % input[1];
    }
}

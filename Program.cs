namespace sistema_de_lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de operações");
            Console.WriteLine("1- Cadastrar usuário");
            Console.WriteLine("2- Editar Usuário");
            Console.WriteLine("3- Excluir Usuário");
            Console.WriteLine("4- Listar Usuários");
            Console.WriteLine("5- Sair");


            Console.Write("Digite a opcao desejada (1 á 5): ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {                
                case 1:
                    Console.WriteLine("Cadastrar usuário");
                    break;
                case 2:
                    Console.WriteLine("Editar usuário");
                    break;
                case 3:
                    Console.WriteLine("Excluir usuário");
                    break;
                case 4:
                    Console.WriteLine("Listar usuários");
                    break;
                case 5:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opcao inválida");
                    break;
            }
        }
    }
}

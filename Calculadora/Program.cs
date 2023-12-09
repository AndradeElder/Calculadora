using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimo_teste_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Tentativas = 3;
            bool sair = false;
            bool refazer = true;
            while (Tentativas >= 1 && sair == false)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=========== CREDENCIAIS ===========");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("========= Digite seu login: =======");
                Console.ForegroundColor = ConsoleColor.Blue;
                var Login = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("== Você logou como:  " + Login + " ==\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("========= Digite sua senha: =======");
                var Senha = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (Login == "elderandrade" && Senha == "123")
                {
                    while (sair == false)
                    {
                        double PrimeiroNumero = 1;
                        double SegundoNumero = 2;
                        double Resultado = 3;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("=========================================");
                        Console.WriteLine("=======                           =======");
                        Console.WriteLine($"=======   Login:  {Login}    =======");
                        Console.WriteLine("=======                           =======");
                        Console.WriteLine("================ OPERAÇÕES ==============");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" [1] + ADIÇÃO");
                        Console.WriteLine(" [2] - SUBTRAÇÃO");
                        Console.WriteLine(" [3] / DIVISÃO");
                        Console.WriteLine(" [4] * MULTIPLICAÇÃO");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" [5] => SAIR");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Adicionar as operaçõs atravez do switch - e vincular PrimeiroNumero , SegundoNumero e Resultado
                        var Operacao = Convert.ToInt32(Console.ReadLine());
                        switch (Operacao)
                        {
                            case 1: // Adição
                                refazer = true;
                                while (refazer == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("============ ADIÇÃO =============");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o primeiro numero:");
                                    PrimeiroNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o Segundo numero:");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    SegundoNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Resultado = PrimeiroNumero + SegundoNumero;
                                    Console.WriteLine($"Resposta: {PrimeiroNumero} + {SegundoNumero} = {Resultado}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                    Console.ReadKey();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" ===== ESCOLHA OUTRA OPÇÃO: =====");
                                    Console.WriteLine(" ==== [1] Refazer operação:  ====");
                                    Console.WriteLine(" ==== [2] voltar:            ====");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    var SubMenuSoma = Convert.ToInt32(Console.ReadLine());
                                    switch (SubMenuSoma)
                                    {
                                        case 1:
                                            refazer = true;
                                            break;
                                        case 2:
                                            refazer = false;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("=================================");
                                            Console.WriteLine($"=======   Login:  {Login}    =======");
                                            Console.WriteLine("=================================");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                break;
                            case 2: // Subtração
                                refazer = true;
                                while (refazer == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("========== Subtração ============");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o primeiro numero:");
                                    PrimeiroNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o Segundo numero:");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    SegundoNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Resultado = PrimeiroNumero - SegundoNumero;
                                    Console.WriteLine($"Resposta: {PrimeiroNumero} - {SegundoNumero} = {Resultado}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                    Console.ReadKey();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" ===== ESCOLHA OUTRA OPÇÃO: =====");
                                    Console.WriteLine(" ==== [1] Refazer operação:  ====");
                                    Console.WriteLine(" ==== [2] voltar:            ====");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    var SubMenuSoma = Convert.ToInt32(Console.ReadLine());
                                    switch (SubMenuSoma)
                                    {
                                        case 1:
                                            refazer = true;
                                            break;
                                        case 2:
                                            refazer = false;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("=================================");
                                            Console.WriteLine($"=======   Login:  {Login}    =======");
                                            Console.WriteLine("=================================");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                break;
                            case 3: // Divisão
                                refazer = true;
                                while (refazer == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("============ Divisão ============");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o primeiro numero:");
                                    PrimeiroNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o Segundo numero:");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    SegundoNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Resultado = PrimeiroNumero / SegundoNumero;
                                    Console.WriteLine($"Resposta: {PrimeiroNumero} / {SegundoNumero} = {Resultado}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                    Console.ReadKey();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" ===== ESCOLHA OUTRA OPÇÃO: =====");
                                    Console.WriteLine(" ==== [1] Refazer operação:  ====");
                                    Console.WriteLine(" ==== [2] voltar:            ====");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    var SubMenuSoma = Convert.ToInt32(Console.ReadLine());
                                    switch (SubMenuSoma)
                                    {
                                        case 1:
                                            refazer = true;
                                            break;
                                        case 2:
                                            refazer = false;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("=================================");
                                            Console.WriteLine($"=======   Login:  {Login}    =======");
                                            Console.WriteLine("=================================");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                break;
                            case 4: // Multiplicação
                                refazer = true;
                                while (refazer == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.WriteLine("=================================");
                                    Console.WriteLine("============ Multiplicação ============");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o primeiro numero:");
                                    PrimeiroNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Digite o Segundo numero:");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    SegundoNumero = Convert.ToDouble(Console.ReadLine()); ;
                                    Resultado = PrimeiroNumero * SegundoNumero;
                                    Console.WriteLine($"Resposta: {PrimeiroNumero} * {SegundoNumero} = {Resultado}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                    Console.ReadKey();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("=================================");
                                    Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" ===== ESCOLHA OUTRA OPÇÃO: =====");
                                    Console.WriteLine(" ==== [1] Refazer operação:  ====");
                                    Console.WriteLine(" ==== [2] voltar:            ====");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    var SubMenuSoma = Convert.ToInt32(Console.ReadLine());
                                    switch (SubMenuSoma)
                                    {
                                        case 1:
                                            refazer = true;
                                            break;
                                        case 2:
                                            refazer = false;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("=================================");
                                            Console.WriteLine($"=======   Login:  {Login}    =======");
                                            Console.WriteLine("=================================");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                break;
                            case 5:
                                sair = true;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("================================= ");
                                Console.WriteLine($"======= USUÁRIO: {Login} ========");
                                Console.WriteLine("================================= ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                Console.ReadKey();
                                break;
                        }
                    }
                }
                else if (Login != "elderandrade" && Senha == "123")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Login invalido! \n");
                    Tentativas--;
                    Console.WriteLine($"{Tentativas} tentativas restantes");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (Login == "elderandrade" && Senha != "123")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Senha invalida! \n");
                    Tentativas--;
                    Console.WriteLine($"{Tentativas} tentativas restantes");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Login e senha invalidos! \n");
                    Tentativas--;
                    Console.WriteLine($"{Tentativas} tentativas restantes");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (Tentativas <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("LIMITE DE TENTATIVAS EXCEDIDO");
                }
            }


        }
    }
}

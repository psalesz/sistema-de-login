using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Digite 'S' para fazer o login ");
        char S;
        S = char.Parse(Console.ReadLine());
        
        if (S == 'S') {
        Console.WriteLine("Ok, vamos redirecionar você a página de registro ou login, Digite 'S' ou qualquer coisa novamente para continuar");
        S = char.Parse(Console.ReadLine());
       
        Console.WriteLine("Digite seu email ou nome de usuário para login");
        string nome;
        nome = Console.ReadLine();
        
        Console.WriteLine("Comfirme seu email ou nome de usuário para login");
        string nome2;
        nome2 = Console.ReadLine();
       
        if (nome2 != nome) {
        Console.WriteLine("Seu nome de usuário ou email está incorreto, Digite certo para comfirmar seu login...");
        nome2 = Console.ReadLine();
        }
        while (nome2 != nome) {
        Console.WriteLine("Seu nome de usuário ou email está incorreto, Digite certo para comfirmar seu login...");
        nome2 = Console.ReadLine();
        }
        if (nome2 == nome) {
        Console.WriteLine("Email ou nome de usuário corretos, agora você será redirecionado para logar com sua senha");
        }
       
       
        Console.WriteLine ("Digite Sua senha para login");
        int senha;
        senha = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Comfirme Sua Senha:");
        int senha2;
        senha2 = int.Parse(Console.ReadLine());
        
        if (senha != senha2) {
        Console.WriteLine("Sua senha está incorreta, Digite Novamente");
        senha2 = int.Parse(Console.ReadLine());
        }
        while (senha != senha2) {
        Console.WriteLine("Sua senha está incorreta, Digite Novamente");
        senha2 = int.Parse(Console.ReadLine());
        }
        if (senha2 == senha) {
        Console.WriteLine("Acesso Liberado");
        }
        }
    }
}
namespace Sistema_de_tarefas_Console_;

class Program{
    static void Main(){

        ListaEstatica lista = new ListaEstatica();
        int opcao = 0;

        opcao = Menu();

        
    }

    static int Menu(){
        Console.WriteLine("====> ESTOQUE FÁCIL <====");
        Console.WriteLine("1 - Listar suas tarefas");
        Console.WriteLine("2 - Adiciona uma tarefa");
        Console.WriteLine("3 - Concluir uma tarefa");
        Console.WriteLine("4 - Remover uma tarefa");
        Console.WriteLine("5 - Buscar tarefa por nome");
        Console.WriteLine("6 - Buscar tarefas da mesma importância");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção desejada:");

        int res = int.Parse(Console.ReadLine()!);

        if(res < 0 || res > 6){
            Console.Clear();
            Console.WriteLine("Opção invalida, tente novamente:");
            Thread.Sleep(2000);
            Console.Clear();
            res = Menu();
        }
        return res;
        
    }
}

namespace Sistema_de_tarefas_Console_;

class Program{
    static void Main(){

        ListaEstatica lista = new ListaEstatica();
        int opcao = 0;


        do{
            Console.Clear();
            opcao = Menu();

            switch (opcao){
                case 1: lista.Imprimir();
                        Thread.Sleep(6000);
                break;

                case 2: Adicionar(lista);
                break;

          /*      case 3: Concluir();
                break;

                case 4: Remover();
                break;

                case 5: Buscar();
                break;   */
                
            }

            
        } while (opcao != 0);

        
    }

    static int Menu(){
        Console.WriteLine("====> ESTOQUE FÁCIL <====");
        Console.WriteLine("1 - Listar suas tarefas");
        Console.WriteLine("2 - Adiciona uma tarefa");
        Console.WriteLine("3 - Concluir uma tarefa");
        Console.WriteLine("4 - Remover uma tarefa");
        Console.WriteLine("5 - Buscar tarefa por nome");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção desejada:");

        string? input = Console.ReadLine();

        if(!int.TryParse(input, out int res) || res < 0 || res > 6){
            Console.Clear();
            Console.WriteLine("Opção invalida, tente novamente:");
            Thread.Sleep(2500);
            Console.Clear();
            res = Menu();
        }
        return res;   
    }

    static void Adicionar(ListaEstatica lista){
        Console.Clear();
        Console.WriteLine("Você deseja adicionar uma tarefa em qual posição?");
        Console.WriteLine("1 - Início");
        Console.WriteLine("2 - Fim");
        Console.WriteLine("3 - Local expecífico");
        Console.WriteLine("Digite a opção desejada:");

        string? input = Console.ReadLine();

        //Verificação de entrada de dados
        if(!int.TryParse(input, out int res) || res < 0 || res > 3){    //Se a string não virar int, for menor que 0 ou maior que 3, ele dá erro e volta para função.
            Console.Clear();
            Console.WriteLine("Opção invalida, tente novamente:");
            Thread.Sleep(2500);
            Console.Clear();
            Adicionar(lista);
        }

        string nome = "", descricao = "";
        int importancia = 0;

        //Função para adicionar no início
        if(input == "1"){
            Console.Clear();
            Console.WriteLine("===== ADICIONAR INÍCIO =====");
            Console.WriteLine("Qual o nome da tarefa?:");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a descrição do projeto?:");
            descricao = Console.ReadLine();

            Console.WriteLine("Qual o nível de importância de 1 a 5?:");
            importancia = int.Parse(Console.ReadLine());

            if(importancia < 1 || importancia > 5){
                Console.WriteLine("Nível de importância invalida.");
                return;
            }

            lista.Adicionar_Inicio(nome, descricao, importancia);

        }

        //Função para adicionar no final
        if(input == "2"){
            Console.Clear();
            Console.WriteLine("===== ADICIONAR FINAL =====");
            Console.WriteLine("Qual o nome da tarefa?:");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a descrição do projeto?:");
            descricao = Console.ReadLine();

            Console.WriteLine("Qual o nível de importância de 1 a 5?:");
            importancia = int.Parse(Console.ReadLine());

            if(importancia < 1 || importancia > 5){
                Console.WriteLine("Nível de importância invalida.");
                return;
            }

            lista.Adicionar_Final(nome, descricao, importancia);

        }
        
        //Função para adicionar na posição desejada
        if(input == "3"){
            Console.Clear();
            Console.WriteLine("===== ADICIONAR LOCAL ESPECÍFICO =====");
            Console.WriteLine("Qual o nome da tarefa?:");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a descrição do projeto?:");
            descricao = Console.ReadLine();

            Console.WriteLine("Qual o nível de importância de 1 a 5?:");
            importancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a posição que deseja inserir a tarefa?");
            int local = int.Parse(Console.ReadLine());

            if(importancia < 1 || importancia > 5){
                Console.WriteLine("Nível de importância invalida.");
                return;
            }

            lista.Adicionar_Pos(local - 1, nome, descricao, importancia);   //Local com um "-1" pois na visão do usuário uma lista não começa com 0, mas sim com 1!

        }
    }
}

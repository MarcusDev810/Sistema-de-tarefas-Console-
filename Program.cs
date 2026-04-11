using System.Security.AccessControl;

namespace Sistema_de_tarefas_Console_;

class Program{
    static void Main(){

        ListaEstatica lista = new ListaEstatica();
        int opcao = 0;


        do{
            Console.Clear();
            opcao = Menu();

            switch (opcao){
                case 1: 
                    lista.Imprimir();
                    Thread.Sleep(6000);
                break;

                case 2: 
                    Adicionar(lista);
                break;

                case 3: 
                    Concluir(lista);
                break;

                case 4: 
                    Remover(lista);
                break;

                case 5: 
                    Buscar(lista);
                break;   
                
            }

            
        } while (opcao != 0);

        
    }

    static int Menu(){
        Console.Clear();

        Console.WriteLine("====> ESTOQUE FÁCIL <====");
        Console.WriteLine("1 - Listar suas tarefas");
        Console.WriteLine("2 - Adiciona uma tarefa");
        Console.WriteLine("3 - Concluir uma tarefa");
        Console.WriteLine("4 - Remover uma tarefa");
        Console.WriteLine("5 - Buscar tarefa");
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
                Thread.Sleep(2000);
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
                Thread.Sleep(2000);
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
                Thread.Sleep(2000);
                return;
            }

            lista.Adicionar_Pos(local - 1, nome, descricao, importancia);   //Local com um "-1" pois na visão do usuário uma lista não começa com 0, mas sim com 1!

        }

    }

    static void Concluir(ListaEstatica lista){
        Console.Clear();

        Console.WriteLine("Qual o ID da terefa que deseja concluir?");
        int con = int.Parse(Console.ReadLine());

        //Somente um loading visual para testes
        Console.Clear();
        Console.Write(". ");
        Thread.Sleep(500);
        Console.Write(". ");
        Thread.Sleep(500);
        Console.Write(". ");
        Thread.Sleep(500);
        Console.Write(". ");
        Thread.Sleep(500);
        Console.Clear();

        Console.WriteLine("Tarefa concluída!!");

        lista.Concluir(con);
        Thread.Sleep(2000);
    }
    static void Remover(ListaEstatica lista){
            
        Console.Clear();
        Console.WriteLine("Você deseja remover a tarefa em qual posição?");
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
            Remover(lista);
        }

        if(input == "1"){
            Console.WriteLine("Removendo a tarefa da primeira posição");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Tarefa removida!!");
            Thread.Sleep(2000);

            lista.Remover_Inicio();
            
        }

        if(input == "2"){
            Console.WriteLine("Removendo a tarefa da ultima posição");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Tarefa removida!!");
            Thread.Sleep(2000);

            lista.Remover_Final();
            
        }

        if(input == "3"){
            Console.WriteLine("Qual a posição da tarefa que deseja remover?");
            int pos = int.Parse(Console.ReadLine());

            //Verifica se a entrada é valida
            if(pos < 0 || pos > lista.Tamanho()){
                Console.Clear();
                Console.WriteLine("Localização inválida");
                Thread.Sleep(2000);
                Remover(lista);
            }

            Console.WriteLine("Removendo a tarefa da posição indicada");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Tarefa removida!!");
            Thread.Sleep(2000);

            lista.Remover_Pos(pos - 1);
            
        }

    }
    static void Buscar(ListaEstatica lista){
                    
        Console.Clear();
        Console.WriteLine("Você deseja fazer qual tipo de busca?");
        Console.WriteLine("1 - Por nome (retorna a primeira tarefa com o nome indicado)");
        Console.WriteLine("2 - Por importância (todos da mesma importância)");
        Console.WriteLine("Digite a opção desejada:");

        string? input = Console.ReadLine();

        //Verificação de entrada de dados
        if(!int.TryParse(input, out int res) || res < 0 || res > 2){    //Se a string não virar int, for menor que 0 ou maior que 3, ele dá erro e volta para função.
            Console.Clear();
            Console.WriteLine("Opção invalida, tente novamente:");
            Thread.Sleep(2500);
            Console.Clear();
            Buscar(lista);
        }

        if(input == "1"){
            Console.Clear();

            Console.WriteLine("Qual o nome da tarefa que você deseja pesquisar?");
            string nome = Console.ReadLine();

            Console.WriteLine($"Buscando tarefa de nome {nome}");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            lista.Buscar_Nome(nome);
        }

        if(input == "2"){
            Console.Clear();

            Console.WriteLine("Qual a importância das tarefas que você deseja pesquisar?");
            int importancia = int.Parse(Console.ReadLine());

            if(importancia < 0 || importancia > 5){
                Console.Clear();

                Console.WriteLine("Nível de importância inexistente!");
                Buscar(lista);
            }

            Console.WriteLine($"Buscando tarefas por importância {importancia}");
            Thread.Sleep(2000);

            //Somente um loading visual para testes
            Console.Clear();
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Clear();
            lista.Buscar_Importancia(importancia);
        }
    }
}

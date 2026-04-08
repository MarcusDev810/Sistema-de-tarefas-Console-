//Criação da Lista estática
public class ListaEstatica{ 

        private int Tam = 0;
        private int Tam_Max;
        private Tarefas[] tarefa;

    public ListaEstatica(){     
        //Construtor da classe

        this.Tam = 0;
        this.Tam_Max = 1000;
        this.tarefa = new Tarefas[Tam_Max];
    }

    public int Tamanho(){       
    //Função que retorna o tamanho da lista
        return Tam;
    }
    
    public void Adicionar_Inicio(string nome, string descricao, int importancia){       
    //Função que adiciona uma tarefa ao inicío da lista
        if(Tam == Tam_Max){
            return;
        }

        for(int i = Tam; i > 0; i--){
            tarefa[i] = tarefa[i - 1];       
        }

        tarefa[0] = new Tarefas(nome, descricao, importancia);
        Tam++;
    }

    public void Adicionar_Pos(int pos, string nome, string descricao, int importancia){
    //Função que adiciona uma tarefa na posição indicada
        if(pos < 0 || pos > Tam){
            return;
        }
         
        if(Tam == Tam_Max){
            return;
        }

        for(int i = Tam; i > pos; i--){
            tarefa[i] = tarefa[i - 1];
        }

        tarefa[pos] = new Tarefas(nome, descricao, importancia);
        Tam++;
    }

    public void Adicionar_Final(string nome, string descricao, int importancia){
    //Função que adiciona uma tarefa na posição final da lista
        if(Tam == Tam_Max){
            return;
        }

        tarefa[Tam] = new Tarefas(nome, descricao, importancia);
        Tam++;
    }

    public Tarefas Remover_Inicio(){
    //Função que remove e retorna a primeira tarefa da lista
        if(Tam == 0){
            return null!;
        }

        Tarefas temp = tarefa[0];

        for(int i = 0; i < Tam -1; i++){
            tarefa[i] = tarefa[i + 1];
        }

        Tam--;
        return temp;
    }

    public Tarefas Remover_Pos(int pos){
    //Função que remove e retorna a tarefa na posição indicada
        if(pos < 0 ||pos >= Tam){
            return null!;
        }
        Tarefas temp = tarefa[pos];

        for(int i = pos; i < Tam - 1; i++){
            tarefa[i] = tarefa[i + 1];
        }

        Tam--;
        return temp;
    }

    public Tarefas Remover_Final(){
    //Função que remove e retorta a ultima tarefa
        if(Tam == 0){
            return null!;
        }

        Tarefas temp = tarefa[Tam - 1];
        tarefa[Tam - 1] = null!;
        Tam--;
        return temp;
    }

    public void Imprimir(){
    //Função que imprime a lista de tarefas
        Console.Clear();
        if(Tam == 0){
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Lista de Tarefas Vazia");
            Console.WriteLine("=========================================================================");
            return;
        }

        Console.WriteLine("=========================================================================");
        for(int i = 0; i < Tam; i++){
            Console.WriteLine($"ID da Tarefa: {i}");
            Console.WriteLine($"Nome da Tarefa: {tarefa[i].Nome}");
            Console.WriteLine($"Descrição da tarefa: {tarefa[i].Descricao}");
            Console.WriteLine($"Nível de importância: {tarefa[i].Importancia}");
            Console.WriteLine($"Concluida?: {tarefa[i].Concluido}");
            Console.WriteLine("=========================================================================");
        }
    }

    public int Buscar_Nome(string nome){
    //Função que busca e retorna a posição da primeira tarefa com o nome indicado

        for( int i = 0; i < Tam; i++){
            if(tarefa[i].Nome.ToUpper() == nome.ToUpper()){
                return i;
            }
        }

        Console.WriteLine("Nome de tarefa não encontrado");
        return -1;  
        
    }
    public int[] Buscar_Importancia(int impor){
    //Função busca e retorna todas as tarefas da importância informada

        int[] temp = new int[Tam];
        int index = 0;

        for( int i = 0; i < Tam; i++){
            if(tarefa[i].Importancia == impor){
                temp[index++] = i;
            }
        }

        int[] saida = new int[index];

        for(int i = 0; i < index; i++){
            saida[i] = temp[i];
        }

        return saida;
    }

    public void Concluir(int loc){
        tarefa[loc].Tarefa_Concluida();
    }
}
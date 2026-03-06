public class ListaEstatica{

        private int Tam = 0;
        private int Tam_Max;
        private Tarefas[] tarefa;

    public ListaEstatica(){

        this.Tam = 0;
        this.Tam_Max = 1000;
        this.tarefa = new Tarefas[Tam_Max];
    }

    public int Tamanho(){
        return Tam;

    }
    
    public void Adicionar_Inicio(string nome, string descricao, int importancia){
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
        if(Tam == Tam_Max){
            return;
        }

        tarefa[Tam] = new Tarefas(nome, descricao, importancia);
        Tam++;
    }

    public Tarefas Remover_Inicio(){
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
        if(Tam == 0){
            return null!;
        }

        Tarefas temp = tarefa[Tam - 1];
        tarefa[Tam - 1] = null!;
        Tam--;
        return temp;
    }

    public void Imprimir(){
        if(Tam == 0){
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Lista de Tarefas Vazia");
            Console.WriteLine("=========================================================================");
            return;
        }

        for(int i = 0; i < Tam; i++){
            Console.WriteLine("=========================================================================");
            Console.WriteLine($"ID da Tarefa: {i}");
            Console.WriteLine($"Nome da Tarefa: {tarefa[i].Nome}");
            Console.WriteLine($"Descrição da tarefa: {tarefa[i].Descricao}");
            Console.WriteLine($"Nível de importância: {tarefa[i].Importancia}");
            Console.WriteLine("=========================================================================");
        }
    }
}
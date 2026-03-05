class ListaEstatica{

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
        if(pos < 0 || pos > tam){
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
}
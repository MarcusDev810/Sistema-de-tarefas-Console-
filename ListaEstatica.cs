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
}
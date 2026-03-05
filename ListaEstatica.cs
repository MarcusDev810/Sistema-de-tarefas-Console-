class ListaEstatica{

        private int Tam = 0;
        private int Tam_Max;
        private Tarefas[] tarefa;

    public ListaEstatica(){

        this.Tam = 0;
        this.Tam_Max = 1000;
        this.tarefa = new Tarefas[Tam_Max];

    }
}
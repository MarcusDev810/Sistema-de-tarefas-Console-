public class Tarefas{

    public string Nome{ get; private set; }
    public string Descricao{get; private set; }
    public int Importancia{ get; private set;}
    public bool Concluido{ get; private set;}

    public Tarefas(string nome, string descricao, int importancia){
        this.Nome = nome;
        this.Descricao = descricao;
        this.Importancia = importancia;
        this.Concluido = false;
    }

    public void Tarefas_Concluida(){
        Concluido = true;
    }

}
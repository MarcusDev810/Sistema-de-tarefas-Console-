public class Tarefas{

    private string Nome{ get; set; }
    private string Descricao{get; set; }
    private int Importancia{ get; set;}
    private bool Concluido{ get; set;}

    public Tarefas(string nome, string descricao, int importancia){
        this.Nome = nome;
        this.Descricao = descricao;
        this.Importancia = importancia;
        this.Concluido = false;
    }

    public void Tarefas_Concluida(bool foi){
        Concluido = true;
    }

}
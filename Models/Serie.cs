namespace CadastroDeSeries;

public class Serie : EntidadeBase
{
    private Genero Genero { get; set; }
    private string? Titulo { get; set;}
    private string? Descricao { get; set;}
    private int Ano { get; set; }
    public bool Excluido { get; set; }

    public Serie(int id, Genero genero, string? titulo, string? descricao, int ano)
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Excluido = false;
    }

    public override string ToString(){
        string retorno = "";
        retorno += "Genero: " + this.Genero + Environment.NewLine;
        retorno += "Título: " + this.Titulo + Environment.NewLine;
        retorno += "Descrição: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
        retorno += "Excluído: " + this.Excluido;
        return retorno;

        //Classe Environment: Fornece informações e meios para manipular o ambiente e a plataforma actuais.
        //Propriedade NewLine: Obtém a cadeia de caracteres de nova linha definida para este ambiente.
    }

    public string? RetornaTitulo(){
        return this.Titulo;
    }

    public int RetornaId(){
        return this.Id;
    }

    public void Excluir(){
        this.Excluido = true;
    }

    public bool RetornaExcluido(){
        return this.Excluido;
    }
}


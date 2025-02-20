namespace CadastroDeSeries;

public abstract class EntidadeBase
{
    public int Id { get; protected set; }

    // Geralmente todas as Classes possuem ID, desta forma implementamos uma Classe base com esse atributo que sera herdado pelas Classes
    // Isso serve para outros atributos também. Por exemplo, caso as regras de negócio solicitem auditoria dos dados, podemos implementar
    // atributos como DataModificacao, UsuárioDaModificacao, DataCriacao etc.
}
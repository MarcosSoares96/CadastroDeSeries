using System.Collections.Generic;


namespace CadastroDeSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();
        void Exclui(int id);
    }
}
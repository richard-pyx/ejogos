using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEquipe
    {
        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();
    }
}

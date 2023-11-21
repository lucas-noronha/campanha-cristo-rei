using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class Voluntario : Pessoa
    {
        private int Id { get; set; }

        private int? EquipeDeInteresseId { get; set; }
        private Equipe EquipeDeInteresse { get; set; }

        #region Encapsulamento
        public int GetId()
        {
            return Id;
        }
        public int? GetEquipeDeInteresseId()
        {
            return EquipeDeInteresseId;
        }
        public void SetEquipeDeInteresseId(int? equipeDeInteresseId)
        {
            EquipeDeInteresseId = equipeDeInteresseId;
        }
        public Equipe GetEquipeDeInteresse()
        {
            return EquipeDeInteresse;
        }
        public void SetEquipeDeInteresse(Equipe equipe)
        {
            EquipeDeInteresse = equipe;
        }
        #endregion

        #region ParaMapeamentoContexto
        public static string GetNameOfId()
        {
            return nameof(Id);
        }
        public static string GetNameOfEquipeDeInteresseId()
        {
            return nameof(EquipeDeInteresseId);
        }
        public static string GetNameOfEquipeDeInteresse()
        {
            return nameof(EquipeDeInteresse);
        }
        #endregion
    }
}

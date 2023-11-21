using Campanha.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class Familia
    {
        private int Id { get; set; }

        //Informações do responsável familiar
        private string Nome { get; set; } 

        private string Nit { get; set; }

        public Genero Genero { get; set; }

        private string Cpf { get; set; }

        private string Logradouro { get; set; }

        private string Bairro { get; set; }

        private string NumeroEndereco { get; set; }

        private string Cep { get; set; }

        private string Celular { get; set; }

        private string TelefoneFixo { get; set; }

        //Informações socioeconomicas do grupo familiar

        private int QtdePessoas { get; set; }

        private double RendaTotalEstimada { get; set; }

        private bool PossuiFilhos { get; set; }

        //Beneficios Familiares
        private ICollection<BeneficioxFamilia> Beneficios => new List<BeneficioxFamilia>();
        private ICollection<BeneficioxFamilia> BeneficiosRecebidos => Beneficios.Any() ? Beneficios.Where(x => x.GetOpcaoBeneficio() == TipoBeneficio.Recebe).ToList() : new List<BeneficioxFamilia>();
        private ICollection<BeneficioxFamilia> BeneficiosDeInteresse => Beneficios.Any() ? Beneficios.Where(x => x.GetOpcaoBeneficio() == TipoBeneficio.TemInteresse).ToList() : new List<BeneficioxFamilia>();

        //Informações religiosas do grupo familiar
        private bool FrequentaIgreja { get; set; }

        private bool PertenceGrupoOracao { get; set; }

        private string IgrejaFrequentada { get; set; }

        private string GrupoOracao { get; set; }

        private bool ReceberPessoasEmCasa { get; set; }

        private string DiasParaReceberPessoas { get; set; }


        //Informacao da campanha

        private int CampanhaId { get; set; }
        private CadastroDeCampanha Campanha { get; set; }


        #region Encapsulamento
        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }

        public string GetTelefoneFixo()
        {
            return TelefoneFixo;
        }
        public void SetTelefoneFixo(string telefoneFixo)
        {
            TelefoneFixo = telefoneFixo;
        }

        public string GetCelular()
        {
            return Celular;
        }
        public void SetCelular(string celular)
        {
            Celular = celular;
        }

        public string GetCep()
        {
            return Cep;
        }
        public void SetCep(string cep)
        {
            Cep = cep;
        }

        public string GetNumeroEndereco()
        {
            return NumeroEndereco;
        }
        public void SetNumeroEndereco(string numeroEndereco)
        {
            NumeroEndereco = numeroEndereco;
        }

        public string GetBairro()
        {
            return Bairro;
        }
        public void SetBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string GetLogradouro()
        {
            return Logradouro;
        }
        public void SetLogradouro(string logradouro)
        {
            Logradouro = logradouro;
        }

        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public Genero GetGenero()
        {
            return Genero;
        }
        public void SetGenero(Genero genero)
        {
            Genero = genero;
        }

        public string GetNit()
        {
            return Nit;
        }
        public void SetNit(string nit)
        {
            Nit = nit;
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public bool GetPossuiFilhos()
        {
            return PossuiFilhos;
        }
        public void SetPossuiFilhos(bool possuiFilhos)
        {
            PossuiFilhos = possuiFilhos;
        }

        public double GetRendaTotalEstimada()
        {
            return RendaTotalEstimada;
        }
        public void SetRendaTotalEstimada(double rendaTotalEstimada)
        {
            RendaTotalEstimada = rendaTotalEstimada;
        }

        public int GetQtdePessoas()
        {
            return QtdePessoas;
        }
        public void SetQtdePessoas(int qtdePessoas)
        {
            QtdePessoas = qtdePessoas;
        }

        public string GetDiasParaReceberPessoas()
        {
            return DiasParaReceberPessoas;
        }
        public void SetDiasParaReceberPessoas(string diasParaReceberPessoas)
        {
            DiasParaReceberPessoas = diasParaReceberPessoas;
        }

        public bool GetReceberPessoasEmCasa()
        {
            return ReceberPessoasEmCasa;
        }
        public void SetReceberPessoasEmCasa(bool receberPessoasEmCasa)
        {
            ReceberPessoasEmCasa = receberPessoasEmCasa;
        }

        public string GetGrupoOracao()
        {
            return GrupoOracao;
        }
        public void SetGrupoOracao(string grupoOracao)
        {
            GrupoOracao = grupoOracao;
        }

        public string GetIgrejaFrequentada()
        {
            return IgrejaFrequentada;
        }
        public void SetIgrejaFrequentada(string igrejaFrequentada)
        {
            IgrejaFrequentada = igrejaFrequentada;
        }

        public bool GetPertenceGrupoOracao()
        {
            return PertenceGrupoOracao;
        }
        public void SetPertenceGrupoOracao(bool pertenceGrupoOracao)
        {
            PertenceGrupoOracao = pertenceGrupoOracao;
        }

        public bool GetFrequentaIgreja()
        {
            return FrequentaIgreja;
        }
        public void SetFrequentaIgreja(bool frequentaIgreja)
        {
            FrequentaIgreja = frequentaIgreja;
        }

        public int GetCampanhaId()
        {
            return CampanhaId;
        }

        public void SetCampanhaId(int campanhaId)
        {
            CampanhaId = campanhaId;
        }
        
        public CadastroDeCampanha GetCampanha()
        {
            return Campanha;
        }
        public void SetCampanha(CadastroDeCampanha campanha)
        {
            CampanhaId = campanha.GetId();
            Campanha = campanha;

        }
        public List<BeneficioxFamilia> GetBeneficiosRecebidos()
        {
            return BeneficiosRecebidos.ToList();
        }
        public List<BeneficioxFamilia> GetBeneficiosDeInteresse()
        {
            return BeneficiosDeInteresse.ToList();
        }
        #endregion

        #region ParaMapeamentoContexto
        public static string GetNameOfId()
        {
            return nameof(Id);
        }

        public static string GetNameOfTelefoneFixo()
        {
            return nameof(TelefoneFixo);
        }

        public static string GetNameOfCelular()
        {
            return nameof(Celular);
        }

        public static string GetNameOfCep()
        {
            return nameof(Cep);
        }

        public static string GetNameOfNumeroEndereco()
        {
            return nameof(NumeroEndereco);
        }

        public static string GetNameOfBairro()
        {
            return nameof(Bairro);
        }

        public static string GetNameOfLogradouro()
        {
            return nameof(Logradouro);
        }

        public static string GetNameOfCpf()
        {
            return nameof(Cpf);
        }

        public static string GetNameOfGenero()
        {
            return nameof(Genero);
        }

        public static string GetNameOfNit()
        {
            return nameof(Nit);
        }

        public static string GetNameOfNome()
        {
            return nameof(Nome);
        }

        public static string GetNameOfPossuiFilhos()
        {
            return nameof(PossuiFilhos);
        }

        public static string GetNameOfRendaTotalEstimada()
        {
            return nameof(RendaTotalEstimada);
        }

        public static string GetNameOfQtdePessoas()
        {
            return nameof(QtdePessoas);
        }

        public static string GetNameOfDiasParaReceberPessoas()
        {
            return nameof(DiasParaReceberPessoas);
        }

        public static string GetNameOfReceberPessoasEmCasa()
        {
            return nameof(ReceberPessoasEmCasa);
        }

        public static string GetNameOfGrupoOracao()
        {
            return nameof(GrupoOracao);
        }

        public static string GetNameOfIgrejaFrequentada()
        {
            return nameof(IgrejaFrequentada);
        }

        public static string GetNameOfPertenceGrupoOracao()
        {
            return nameof(PertenceGrupoOracao);
        }

        public static string GetNameOfFrequentaIgreja()
        {
            return nameof(FrequentaIgreja);
        }

        public static string GetNameOfCampanhaId()
        {
            return nameof(CampanhaId);
        }
        public static string GetNameOfCampanha()
        {
            return nameof(Campanha);
        }
        public static string GetNameOfBeneficios()
        {
            return nameof(Beneficios);
        }
        #endregion
    }


}

using Campanha.Domain.Entidades;
using Campanha.Domain.Enums;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public class FamiliaDto : TDto<Familia, FamiliaDto>
    {
        public FamiliaDto()
        {}
        public FamiliaDto(Familia entidade)
        {
            Id = entidade.GetId();
            TelefoneFixo = entidade.GetTelefoneFixo();
            Celular = entidade.GetCelular();
            Cep = entidade.GetCep();
            NumeroEndereco = entidade.GetNumeroEndereco();
            Bairro = entidade.GetBairro();
            Logradouro = entidade.GetLogradouro();
            Cpf = entidade.GetCpf();
            Genero = entidade.GetGenero();
            Nit = entidade.GetNit();
            Nome = entidade.GetNome();
            PossuiFilhos = entidade.GetPossuiFilhos();
            RendaTotalEstimada = entidade.GetRendaTotalEstimada();
            QtdePessoas = entidade.GetQtdePessoas();
            DiasParaReceberPessoas = entidade.GetDiasParaReceberPessoas();
            ReceberPessoasEmCasa = entidade.GetReceberPessoasEmCasa();
            GrupoOracao = entidade.GetGrupoOracao();
            IgrejaFrequentada = entidade.GetIgrejaFrequentada();
            PertenceGrupoOracao = entidade.GetPertenceGrupoOracao();
            FrequentaIgreja = entidade.GetFrequentaIgreja();
            CampanhaId = entidade.GetCampanhaId();

            if (entidade.GetCampanha() != null)
            {
                Campanha = CampanhaDto.CriarDto(entidade.GetCampanha());
            }
            if (entidade.GetBeneficiosDeInteresse().Any())
            {
                BeneficiosDeInteresse.AddRange(entidade.GetBeneficiosDeInteresse().Select(x => BeneficiosPorFamiliaDto.CriarDto(x)).ToList());
            }
            if (entidade.GetBeneficiosRecebidos().Any())
            {
                BeneficiosRecebidos.AddRange(entidade.GetBeneficiosRecebidos().Select(x => BeneficiosPorFamiliaDto.CriarDto(x)).ToList());
            }
        }
        public int? Id { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Cpf { get; set; }
        public Genero Genero { get; set; }
        public string Nit { get; set; }
        public string Nome { get; set; }
        public bool PossuiFilhos { get; set; }
        public double RendaTotalEstimada { get; set; }
        public int QtdePessoas { get; set; }
        public string DiasParaReceberPessoas { get; set; }
        public bool ReceberPessoasEmCasa { get; set; }
        public string GrupoOracao { get; set; }
        public string IgrejaFrequentada { get; set; }
        public bool PertenceGrupoOracao { get; set; }
        public bool FrequentaIgreja { get; set; }
        public int CampanhaId { get; set; }
        public CampanhaDto Campanha { get; set; }

        public List<BeneficiosPorFamiliaDto> BeneficiosDeInteresse { get; set; }

        public List<BeneficiosPorFamiliaDto> BeneficiosRecebidos { get; set; }

        public Familia CriarOuAlterarEntidade(Familia familia = null)
        {
            var entidade = familia;
            if (entidade == null)
            {
                entidade = new Familia();
                
            }
            entidade.SetCampanhaId(CampanhaId);
            entidade.SetTelefoneFixo(TelefoneFixo);
            entidade.SetCelular(Celular);
            entidade.SetCep(Cep);
            entidade.SetNumeroEndereco(NumeroEndereco);
            entidade.SetBairro(Bairro);
            entidade.SetLogradouro(Logradouro);
            entidade.SetCpf(Cpf);
            entidade.SetGenero(Genero);
            entidade.SetNit(Nit);
            entidade.SetNome(Nome);
            entidade.SetPossuiFilhos(PossuiFilhos);
            entidade.SetRendaTotalEstimada(RendaTotalEstimada);
            entidade.SetQtdePessoas(QtdePessoas);
            entidade.SetDiasParaReceberPessoas(DiasParaReceberPessoas);
            entidade.SetReceberPessoasEmCasa(ReceberPessoasEmCasa);
            entidade.SetGrupoOracao(GrupoOracao);
            entidade.SetIgrejaFrequentada(IgrejaFrequentada);
            entidade.SetPertenceGrupoOracao(PertenceGrupoOracao);
            entidade.SetFrequentaIgreja(FrequentaIgreja);
            
            
            return entidade;
        }

        public static FamiliaDto CriarDto(Familia entidade)
        {
            return new FamiliaDto(entidade);
        }
    }
}

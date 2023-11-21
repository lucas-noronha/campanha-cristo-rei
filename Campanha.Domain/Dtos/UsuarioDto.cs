using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public class UsuarioDto : PessoaDto, TDto<Usuario, UsuarioDto>
    {
        public UsuarioDto(Usuario usuario) : base(usuario)
        {
            Id = usuario.GetId();
            Cargo = usuario.GetCargo();
            Login = usuario.GetLogin();
            Senha = usuario.GetSenha();
            EquipeId = usuario.GetEquipeId();
            if (usuario.GetEquipe() != null)
            {
                Equipe = EquipeDto.CriarDto(usuario.GetEquipe());
            }
            Ativo = usuario.GetAtivo();
        }

        public string Cargo { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public int? EquipeId { get; set; }

        public EquipeDto Equipe { get; set; }

        public bool Ativo { get; set; }

        public Usuario CriarOuAlterarEntidade(Usuario usuario = null)
        {
            var entidade = usuario;
            if (entidade == null)
            {
                entidade = new Usuario(this.Nome, this.Login, this.Senha);
            }
            base.CriarOuAlterarEntidade(usuario);
            entidade.SetCargo(Cargo);
            entidade.SetLogin(Login);
            entidade.SetSenha(Senha);
            entidade.SetEquipeId(EquipeId);
            entidade.SetAtivo(Ativo);

            return entidade;
            
        }

        public static UsuarioDto CriarDto(Usuario entidade)
        {
            return new UsuarioDto(entidade);
        }
    }
}

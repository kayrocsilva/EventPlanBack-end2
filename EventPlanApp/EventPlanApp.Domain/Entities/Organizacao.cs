using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanApp.Domain.Entities
{
    public class Organizacao
    {
        public int OrganizacaoId { get; set; }
        public string CNPJ { get; set; }
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string NumeroPredio { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public decimal NotaMedia { get; set; }

        // Relacionamento com Eventos
        public ICollection<Evento> Eventos { get; set; }

        // Relacionamento com UsuarioAdm
        public int UsuarioAdmId { get; set; }
        public UsuarioAdm UsuarioAdm { get; set; }
    }
}

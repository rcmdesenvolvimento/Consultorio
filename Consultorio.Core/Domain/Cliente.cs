using System;

namespace Consultorio.Core.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Char Sexo { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
    }
}
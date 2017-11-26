using System;
using System.Collections.Generic;

namespace TestLTM.Domain.Entities
{
    public class Produto
    {
        public Guid IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}

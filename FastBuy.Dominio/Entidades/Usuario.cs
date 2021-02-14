﻿using System.Collections.Generic;

namespace FastBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        // Ususario pode ter um ou muitos pedidos
        public ICollection<Pedido> Pedidos  { get; set; }
    }
}

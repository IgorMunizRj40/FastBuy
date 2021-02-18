﻿namespace FastBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("A descrição do produto não foi informado");
        }
    }
}

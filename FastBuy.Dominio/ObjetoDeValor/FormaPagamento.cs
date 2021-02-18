using FastBuy.Dominio.Enumerados;

namespace FastBuy.Dominio.ObjetoDeValor
{
    //classe de apoio
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto 
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool EhCartaoDebito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDebito; }
        }
        public bool EhPix
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Pix; }
        }
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

    }
}

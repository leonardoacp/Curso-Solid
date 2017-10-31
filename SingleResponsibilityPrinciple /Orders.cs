namespace Solid.SingleResponsibilityPrinciple 
{
    public class Orders{

        public void CriaPedido(){}

        public void CriaPedidoDeGrupo(){}

        public void RealizaPagamento(){}

        public object DownloadBoletoPagamento() => new object();
    }
}

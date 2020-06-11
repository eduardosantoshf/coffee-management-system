using System;

namespace ProjetoBD
{
    internal class Produto
    {
        private int _prodID;
        private float _prodPreco;
        private string _prodNome;
        private int _prodTipo;
        private int _prodQuantidade=1;

        public Produto() { }
        public int ID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }
        public float preco
        {
            get { return _prodPreco; }
            set { _prodPreco = value; }
        }
        public string nome
        {
            get { return _prodNome; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nome do produto nao pode ser null");
                    return;
                }
                _prodNome = value;
            }
        }
        public int tipo
        {
            get { return _prodTipo; }
            set { _prodTipo = value; }
        }
        public int quantidade
        {
            get { return _prodQuantidade; }
            set { _prodQuantidade = value; }
        }
        public override string ToString()
        {
            return (String)String.Format("[ ID:"+_prodID + " ] " + _prodNome + " {0:0.00}€   Qty:"+_prodQuantidade, _prodPreco);
        }

    }
}
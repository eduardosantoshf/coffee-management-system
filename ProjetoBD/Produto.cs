using System;

namespace ProjetoBD
{
    internal class Produto
    {
        private int _prodID;
        private float _prodPreco;
        private string _prodNome;
        private int _prodTipo;

        public Produto() { }
        public int ID
        {
            get { return _prodID; }
            set
            {
                if (value == null)
                {
                    throw new Exception("ID do produto nao pode ser null");
                    return;
                }
                _prodID = value;
            }
        }
        public float preco
        {
            get { return _prodPreco; }
            set
            {
                if (value == null)
                {
                    throw new Exception("preco do produto nao pode ser null");
                    return;
                }
                _prodPreco = value;
            }
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
            set
            {
                if (value == null)
                {
                    throw new Exception("Tipo do produto nao pode ser null");
                    return;
                }
                _prodTipo = value;
            }
        }
        public override string ToString()
        {
            return (String)String.Format("{0,-20} {1 ,-40}", "ID: " + _prodID, "Nome: " + _prodNome);
        }
        
    }
}
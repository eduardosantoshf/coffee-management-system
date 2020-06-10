using System;

namespace ProjetoBD
{
    internal class Empregado
    {
        private int _empNIF;
        private int _NIF_cafe;
        private int _empIdade;
        private string _empNome;
        private DateTime _data_inic_contrato;

        public Empregado() { }
        public int NIF
        {
            get { return _empNIF; }
            set
            {
                if (value == null)
                {
                    throw new Exception("NIF do Empregado nao pode ser null");
                    return;
                }
                _empNIF = value;
            }
        }
        public int NIF_cafe
        {
            get { return _NIF_cafe; }
            set
            {
                if (value == null)
                {
                    throw new Exception("NIF do cafe (empregado) nao pode ser null");
                    return;
                }
                _NIF_cafe = value;
            }
        }
        public int idade
        {
            get { return _empIdade; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Idade do empregado nao pode ser null");
                    return;
                }
                _empIdade = value;
            }
        }
        public string nome
        {
            get { return _empNome; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Nome of empregado can't be null");
                    return;
                }
                _empNome = value;
            }
        }
        public DateTime dataInicContrato
        {
            get { return _data_inic_contrato; }
            set
            {
                if (value == null)
                {
                    throw new Exception("data inicio contrato empregado can't be null");
                    return;
                }
                _data_inic_contrato = value;
            }
        }
        public override string ToString()
        {
            return (String)String.Format("{0,-20} {1 ,-40}", "NIF: " + _empNIF, "Nome: "+_empNome);
        }
    }
}
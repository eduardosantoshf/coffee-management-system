using System;

namespace ProjetoBD
{
    public class Recibo
    {
        private int _ClienteNIF;
        private int _EmpNIF;
        private DateTime _data_recibo;
        private float _valor;

        public int ClienteNIF
        {
            get { return _ClienteNIF; }
            set {
                if (value == null )
                {
                    throw new Exception("´Cliente NIF can't be null");
                    return;
                }
                _ClienteNIF = value; 
            }
        }
        public int EmpNIF
        {
            get { return _EmpNIF; }
            set {
                if (value == null )
                {
                    throw new Exception("Empregado NIF can't be null");
                    return;
                }
                _EmpNIF = value;
            }
        }
        public DateTime data_recibo
        {
            get { return _data_recibo; }
            set { _data_recibo = value; }
        }
        public float valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}

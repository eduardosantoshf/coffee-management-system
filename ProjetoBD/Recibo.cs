using System;

namespace ProjetoBD
{
    public class Recibo
    {
        private int  _reciboID;
        private int _ClienteNIF;
        private int _EmpNIF;
        private DateTime _data_recibo;
        private float _valor;

        public int reciboID
        {
            get { return _reciboID; }
            set {
                if (value == null )
                {
                    throw new Exception("Recibo ID can't be null");
                    return;
                }
                _reciboID = value; 
            }
        }
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
            get { return _ClienteNIF; }
            set {
                if (value == null )
                {
                    throw new Exception("Empregado NIF can't be null");
                    return;
                }
                _ClienteNIF = value;
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

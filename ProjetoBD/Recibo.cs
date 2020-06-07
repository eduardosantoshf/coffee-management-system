using System;

namespace ProjetoBD
{
    public class Recibo
    {
        private int  _reciboID;
        private String _ClienteNIF;
        private String _EmpNIF;
        private String _data_recibo;
        private String _valor;

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
        public String ClienteNIF
        {
            get { return _ClienteNIF; }
            set {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("´Cliente NIF can't be null");
                    return;
                }
                _ClienteNIF = value; 
            }
        }
        public String EmpNIF
        {
            get { return _ClienteNIF; }
            set {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("Empregado NIF can't be null");
                    return;
                }
                _ClienteNIF = value;
            }
        }
        public String data_recibo
        {
            get { return _ClienteNIF; }
            set { _ClienteNIF = value; }
        }
        public String valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}

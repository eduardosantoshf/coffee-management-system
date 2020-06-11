using System;

namespace ProjetoBD
{
    internal class Cliente
    {
            private int _clienteNIF;
            private string _clienteNome;

            public Cliente() { }
            public int NIF
            {
                get { return _clienteNIF; }
                set { _clienteNIF = value; }
            }
            public string nome
            {
                get { return _clienteNome; }
                set
                {
                    if (value == null)
                    {
                        throw new Exception("Nome do cliente nao pode ser null");
                        return;
                    }
                    _clienteNome = value;
                }
            }
            public override string ToString()
            {
                return (String)String.Format("{0,-20} {1 ,-40}", "NIF: " + _clienteNIF, "Nome: " + _clienteNome);
            }

        }
    }

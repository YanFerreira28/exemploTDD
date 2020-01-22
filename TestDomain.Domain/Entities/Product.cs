using System;

namespace TestDomain.Domain.Entities
{
    public class Product
    {

        #region[Properties]

        public int idProduto { get; private set; }
        public string nome { get; private set; }
        public string fornecedor { get; private set; }
        public string marca { get; private set; }
        public decimal valor { get; private set; }
        public Client cliente { get; private set; }


        public const int LenghtMax = 50;
        public const int LengthMin = 3;

        #endregion

        #region[Constructor]

        public Product(string name, string forn, string marc, decimal value)
        {
            ifNullOrEmpty(nome);
            ifNullOrEmpty(fornecedor);
            ifNullOrEmpty(marca);
            minValue(value);
            maxLenghtPassed(nome);
            maxLenghtPassed(fornecedor);
            maxLenghtPassed(marca);
            minLenghtNotPassed(nome);
            minLenghtNotPassed(fornecedor);
            minLenghtNotPassed(marca);
            nome = name;
            fornecedor = forn;
            marca = marca;
            valor = value;
        }

        #endregion

        #region[Methods]

        public static void ifNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Campo não pode ser vazio e nem nulo");
        }

        public static void maxLenghtPassed(string value)
        {
            if (value.Length > LenghtMax)
                throw new Exception(String.Format("O Campo não pode ter mais que {0} Caracteres", LenghtMax));
        }

        public static void minValue(decimal value)
        {
            if (value <= 0)
                throw new Exception("verifique o valor digitado não pode ser menor ou igual a 0");
        }

        public static void minLenghtNotPassed(string value)
        {
            if (value.Length < LengthMin)
                throw new Exception(String.Format("O campo deve ter mais que {0}", LengthMin));
        }

        #endregion
    }
}
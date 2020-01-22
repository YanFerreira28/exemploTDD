using System;
using System.Collections.Generic;

namespace TestDomain.Domain.Entities
{
    public class Client
    {
        public int id { get; private set; }
        public string nome { get; private set; }
        public string sobrenome { get; private set; }
        public string idade { get; private set; }
        public ICollection<Product> produto { get; private set; }

        public const int maxLenghtString = 50;
        public const int minLenghtString = 3;
        public const int maxAge = 3;

        public Client(string name, string fullname, string age)
        {
            IsNullOrEmpty(nome);
            IsNullOrEmpty(fullname);
            IsNullOrEmpty(age);
            ValidadeMaxAge(age);
            ValidateMaxLengh(name);
            ValidateMaxLengh(fullname);
            ValidateMinLenght(name);
            ValidateMinLenght(fullname);
            nome = name;
            sobrenome = fullname;
            idade = age;
        }

        public static void IsNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Verifique o campo nome");
        }

        public static void ValidateMaxLengh(string value)
        {
            if (value.Length > maxLenghtString)
                throw new Exception("Esse campo não pode ter mais de 50 caracteres");
        }

        public static void ValidateMinLenght(string value)
        {
            if (value.Length < minLenghtString)
                throw new Exception("o valor deve ser maior que " + minLenghtString);
        }

        public static void ValidadeMaxAge(string value)
        {
            if (value.Length > maxAge)
                throw new Exception("Idade não pode ser maior que 3 caracteres");
        }
    }
}
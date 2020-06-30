using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PROJETOMVCB35.DTO
{
    public class tblClienteDTO
    {
        private string cpf;
        private string name;
        private string surname;
        private string email;
        private string password;
        private string motherName;
        private int type;


        public tblClienteDTO(string cpf,string name,string surname,string email,string password,string mothername)
        {
            Cpf = cpf;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            MotherName = mothername;
        }

        public string Cpf
        {
            get => cpf;
            set
            {
                if (value != string.Empty)
                {
                    const string rgPattern = @"\D";
                    Regex rg = new Regex(rgPattern);

                    if (!rg.IsMatch(value))
                        cpf = value;
                    else
                        throw new Exception("O cpf não deve conter letras");
                }
                else
                {
                    throw new Exception("Não deixe o cpf vazio");
                }
            }
        }
        public string Email
        {
            get => email;

            set
            {
                if (value != string.Empty)
                {
                    const string rgPattern = @"@";
                    Regex rg = new Regex(rgPattern);

                    if (rg.IsMatch(value))
                        email = value;
                    else
                        throw new Exception("Email inválido");
                }
                else
                {
                    throw new Exception("Não deixe o email vazio");
                }
            }
        }
        public string Name { get => name; set { if (value != string.Empty) { name = value; } else { throw new Exception("Não deixe o nome vazio"); } } }
        public string Surname { get => surname; set { if (value != string.Empty) { surname = value; } else { throw new Exception("Não deixe o sobrenome vazio"); } } }
        public string Password { get => password; set { if (value != string.Empty) { password = value; } else { throw new Exception("Não deixe a senha vazia"); } } }
        public string MotherName { get => motherName; set { if (value != string.Empty) { motherName = value; } else { throw new Exception("Não deixe o nome da mãe vazio"); } } }
        public int Type { get => type; set => type = value; }


    }
}
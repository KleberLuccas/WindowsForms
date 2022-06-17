using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json; 

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório.")]
            [RegularExpression("([0-9]+)",ErrorMessage = "Código do cliente deve conter apenas números.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Codigo do cliente deve ter 6 dígitos.")]
            public string Id { get; set; }


            [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve ter menos do que 50 caracteres.")]
            public string Nome { get; set; }


            [StringLength(50, ErrorMessage = "Nome do pai do cliente deve ter menos do que 50 caracteres.")]
            public string NomeDoPai { get; set; }


            [Required(ErrorMessage = "Nome da mãe é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome a mãe do cliente deve ter menos do que 50 caracteres.")]
            public string NomeDaMae { get; set; }

            public bool TemPai { get; set; }

            [Required(ErrorMessage = "CPF é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF do cliente deve conter apenas números.")]
            [StringLength(11, ErrorMessage = "CPF do cliente deve ter menos do que 11 dígitos.")]
            public string CPF { get; set; }

            [Required(ErrorMessage = "Gênero é obrigatório.")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP do cliente deve conter apenas números.")]
            [StringLength(8, MinimumLength = 8,ErrorMessage = "CEP do cliente deve ter menos do que 8 dígitos.")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "Logradouro é obrigatório.")]
            [StringLength(100, ErrorMessage = "Logradouro do cliente deve ter menos do que 100 caracteres.")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatório.")]
            [StringLength(50, ErrorMessage = "Complemento do cliente deve ter menos do que 50 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro do cliente deve ter menos do que 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatório.")]
            [StringLength(30, ErrorMessage = "Cidade do cliente deve ter menos do que 30 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório.")]
            [StringLength(30, ErrorMessage = "Estado do cliente deve ter menos do que 30 caracteres.")]
            public string Estado { get; set; }


            [Required(ErrorMessage = "Número de telefone é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Número de telefone do cliente deve conter apenas números.")]
            public string telefone { get; set; }
            public string profissao { get; set; }

            [Required(ErrorMessage = "Renda Familiar é obrigatório.")]
            [Range(0, Double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo.")]
            public Double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComponente()
            {
                if (this.NomeDoPai == this.NomeDaMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais");
                }
                if (this.TemPai == false)
                {
                    if (this.NomeDoPai == "")
                    {
                        throw new Exception("Nome do pai não deve estar vazio quando a propriedade Pai Desconhecido estiver desmarcado.");
                    }
                }
                bool ValidaCPF = Cls_Uteis.Valida(this.CPF);
                if (ValidaCPF == false)
                {
                    throw new Exception("CPF Inválido");
                }
                
            }
        }

        

        public class list
        {
            public List<unit> ListUnit { get; set; }
        }

        public static unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<unit>(vJson);
        }

        public static string SerializedClassUnit(unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}

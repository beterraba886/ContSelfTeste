using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContSelf.Models
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }
        public string? Nome { get; set; }
       [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
        public decimal Salario { get; set; }
        public string? Atividades { get; set; }
    }
}

/*
CREATE TABLE FUNCIONARIO (CodFuncionario INT NOT NULL IDENTITY(1,1) PRIMARY KEY, Nome VARCHAR(400), DataNascimento datetime, Salario numeric(18,2), Atividades VARCHAR(MAX))
*/


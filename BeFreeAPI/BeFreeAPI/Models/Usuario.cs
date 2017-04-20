namespace BeFreeAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbUsuario")]
    public partial class Usuario
    {
        [Key]
        [Column(Order = 0)]
        public int idUsuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string nomeUsuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(18)]
        public string cpf { get; set; }

        public int? idCidade { get; set; }

        public int? idEstado { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        [StringLength(100)]
        public string logradouro { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        public DateTime? dataNascimento { get; set; }

        public DateTime? dataCadastro { get; set; }

        public bool? ativo { get; set; }
    }
}

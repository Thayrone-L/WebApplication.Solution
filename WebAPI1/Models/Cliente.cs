using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System.Web;

namespace WebAPI.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Id = 0;
            CPF = "";
            Nome = "";
            RG = "";
            OrgaoExpedicao = "";
            UfExpedicao = "";
            Sexo = "";
            EstadoCivil = "";
            endereco = new Endereco();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o CPF.")]
        [ValidacaoCPF]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o nome.")]
        [ValidacaoNome]
        public string Nome { get; set; }

        public string RG { get; set; }

        [ValidacaoData(false)]
        [DisplayName("Data de expedição")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de expedição")]
        public DateTime? DataExpedicao { get; set; }

        public string OrgaoExpedicao { get; set; }

        public string UfExpedicao { get; set; }

        [ValidacaoData(true)]
        [DisplayName("Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o sexo.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Preencha o estado civil.")]
        public string EstadoCivil { get; set; }

        public Endereco endereco { get; set; }
    }
    public class Endereco
    {
        public Endereco()
        {
            CEP = "";
            Logradouro = "";
            Numero = "";
            Complemento = "";
            Bairro = "";
            Cidade = "";
            UF = "";
        }
        [Required(ErrorMessage = "Preencha o CEP.")]
        [ValidacaoCEP]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencha o logradouro.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o numero.")]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o bairro.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha a cidade.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o UF.")]
        public string UF { get; set; }
    }
}
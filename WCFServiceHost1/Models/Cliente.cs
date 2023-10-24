using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

[DataContract] // Adicione a anotação DataContract
public class Cliente
{
    public Cliente()
    {
    }

    [DataMember] // Adicione a anotação DataMember
    public int Id { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o CPF.")]
    public string CPF { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o nome.")]
    public string Nome { get; set; }

    [DataMember]
    public string RG { get; set; }

    [DataMember]
    public DateTime? DataExpedicao { get; set; }

    [DataMember]
    public string OrgaoExpedicao { get; set; }

    [DataMember]
    public string UfExpedicao { get; set; }

    [DataMember]
    public DateTime DataNascimento { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o sexo.")]
    public string Sexo { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o estado civil.")]
    public string EstadoCivil { get; set; }

    [DataMember]
    public Endereco Endereco { get; set; } 
}
[DataContract]
public class Endereco
{
    public Endereco()
    {
    }

    [DataMember]
    [Required(ErrorMessage = "Preencha o CEP.")]
    public string CEP { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o logradouro.")]
    public string Logradouro { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o numero.")]
    public string Numero { get; set; }

    [DataMember]
    public string Complemento { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o bairro.")]
    public string Bairro { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha a cidade.")]
    public string Cidade { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Preencha o UF.")]
    public string UF { get; set; }
}

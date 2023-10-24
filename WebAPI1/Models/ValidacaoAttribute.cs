using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class ValidacaoCPFAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string cpf)
        {
            ValidationResult validationResult = ValidaCPF(cpf);

            if (validationResult != ValidationResult.Success)
            {
                return validationResult;
            }
        }

        return ValidationResult.Success;
    }
    private ValidationResult ValidaCPF(string cpf)
    {
        if (cpf == null)
        {
            cpf = string.Empty;
        }

        string numerosCPF = Regex.Replace(cpf, @"[^\d]", "");

        numerosCPF = numerosCPF.Trim();

        if (numerosCPF.Length != 11)
        {
            return new ValidationResult("O CPF deve ter 11 dígitos.");
        }

        int[] digits = new int[11];
        for (int i = 0; i < 11; i++)
        {
            digits[i] = int.Parse(numerosCPF[i].ToString());
        }

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += digits[i] * (10 - i);
        }

        int restante = sum % 11;
        int digit1 = (restante < 2) ? 0 : 11 - restante;

        if (digits[9] != digit1)
        {
            return new ValidationResult("CPF inválido.");
        }

        sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += digits[i] * (11 - i);
        }

        restante = sum % 11;
        int digit2 = (restante < 2) ? 0 : 11 - restante;

        if (digits[10] != digit2)
        {
            return new ValidationResult("CPF inválido.");
        }

        return ValidationResult.Success;
    }
}

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class ValidacaoNomeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string nome)
        {
            ValidationResult validationResult = ValidaNome(nome);

            if (validationResult != ValidationResult.Success)
            {
                return validationResult;
            }
        }

        return ValidationResult.Success;
    }

    static ValidationResult ValidaNome(string nome)
    {
        nome = nome.Trim();

        if (nome.Length <= 3)
        {
            return new ValidationResult("O nome deve ter mais de 3 caracteres.");
        }

        if (nome.Any(char.IsDigit))
        {
            return new ValidationResult("O nome não pode conter números.");
        }

        return ValidationResult.Success;
    }
}

public sealed class ValidacaoDataAttribute : ValidationAttribute
{
    private readonly bool obrigatorio;

    public ValidacaoDataAttribute(bool obrigatorio)
    {
        this.obrigatorio = obrigatorio;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (!obrigatorio && value == null)
        {
            return ValidationResult.Success; // Data é opcional e pode ser nula
        }

        if (value is DateTime data)
        {
            ValidationResult validationResult = ValidaData(data);

            if (validationResult != ValidationResult.Success)
            {
                return validationResult;
            }
        }
        else
        {
            return new ValidationResult("Este campo deve conter uma data válida.");
        }

        return ValidationResult.Success;
    }

    static ValidationResult ValidaData(DateTime data)
    {
        DateTime dataLimite = new DateTime(1900, 1, 1);

        if (data < dataLimite)
        {
            return new ValidationResult("A data não pode ser menor que 01/01/1900.");
        }

        if (data > DateTime.Now)
        {
            return new ValidationResult("A data não pode ser maior que a data atual.");
        }

        return ValidationResult.Success;
    }
}


public sealed class ValidacaoCEPAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is string cep)
        {
            ValidationResult validationResult = ValidaCEP(cep);

            if (validationResult != ValidationResult.Success)
            {
                return validationResult;
            }
        }

        return ValidationResult.Success;
    }

    static ValidationResult ValidaCEP(string cep)
    {
        string cepLimpo = new string(cep.Where(char.IsDigit).ToArray());

        if (cepLimpo.Length != 8)
        {
            return new ValidationResult("O CEP deve ter 8 dígitos.");
        }

        if (!cepLimpo.All(char.IsDigit))
        {
            return new ValidationResult("O CEP deve conter apenas números.");
        }

        return ValidationResult.Success;
    }
}

using System.Reflection.Metadata.Ecma335;

namespace Funcionario_WebApi.Models;

public class ServiceResponse<T>
{
    public T? Dados { get; set; }
    public string? Mensagem { get; set; }
    public bool? Sucesso { get; set; }
}

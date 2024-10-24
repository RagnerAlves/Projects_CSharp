using Funcionario_WebApi.Models;

namespace Funcionario_WebApi.Service.FuncionarioService;

public interface IFuncionarioService
{
    Task<ServiceResponse<List<FuncionarioModel>>>? GetFuncionarios();

    Task<ServiceResponse<List<FuncionarioModel>>>? CreateFuncionario(FuncionarioModel novoFuncionario);
    Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);

    Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editadoFuncionario);
    Task<ServiceResponse<List<FuncionarioModel>>>  DeleteFuncionario(int id);
}

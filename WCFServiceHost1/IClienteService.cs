using System.ServiceModel;

[ServiceContract]
public interface IClienteService
{
    [OperationContract]
    [WebInvoke(Method = "POST", UriTemplate = "AdicionarCliente")]
    void AdicionarCliente(Cliente cliente);

    [OperationContract]
    [WebInvoke(Method = "GET", UriTemplate = "ObterClientePorId/{id}")]
    Cliente ObterClientePorId(string id);

    [OperationContract]
    [WebInvoke(Method = "PUT", UriTemplate = "AtualizarCliente")]
    void AtualizarCliente(Cliente cliente);

    [OperationContract]
    [WebInvoke(Method = "DELETE", UriTemplate = "ExcluirCliente/{id}")]
    void ExcluirCliente(string id);

    [OperationContract]
    [WebInvoke(Method = "GET", UriTemplate = "ContarClientes")]
    int ContarClientes();
}

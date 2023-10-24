using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebMVC.Models;
using Newtonsoft.Json;

public class ClientesController : Controller
{
    private readonly HttpClient _httpClient;

    public ClientesController()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:7256/api/"),
        };
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // GET: Clientes/Create
    public ActionResult Create(int? idCliente)
    {
        Cliente cliente = new Cliente();
        if (idCliente != null)
        {
            try
            {

                var response = _httpClient.GetAsync($"clientes/{idCliente}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    cliente = JsonConvert.DeserializeObject<Cliente>(content);
                }
                else
                {

                    return RedirectToAction("Error");
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
        }
        return View(cliente);
    }

    [HttpPost]
    public async Task<ActionResult> Create(Cliente cliente)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var clienteJson = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(clienteJson, System.Text.Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("clientes", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
            catch (Exception ex)
            {

                return RedirectToAction("Error");
            }
        }
        return View(cliente);
    }
    public ActionResult Error()
    {
        // Ação para exibir a página de erro
        return View();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _httpClient.Dispose();
        }
        base.Dispose(disposing);
    }
}
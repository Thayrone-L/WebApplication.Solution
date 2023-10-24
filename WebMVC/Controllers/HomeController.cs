using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web.Mvc;
using System;
using WebMVC.Models;
using System.Linq;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:7256/api/"),
        };
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public ActionResult Index(int page = 1)
    {
        int pageSize = 10;
        List<Cliente> allClients = new List<Cliente>();

        try
        {
            var response = _httpClient.GetAsync("clientes/obterclientes").Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                allClients = JsonConvert.DeserializeObject<List<Cliente>>(content);
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

        int totalClients = allClients.Count;
        int totalPages = (int)Math.Ceiling((double)totalClients / pageSize);

        List<Cliente> clientsForPage = allClients.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        ViewBag.TotalPages = totalPages;
        ViewBag.CurrentPage = page;

        return View(clientsForPage);
    }
    public ActionResult Create()
    {
        return RedirectToAction("Create", "Clientes");
    }

    public ActionResult Error()
    {
        ViewBag.ErrorMessage = "Ocorreu um erro ao listar os clientes. Por favor, tente novamente mais tarde.";
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

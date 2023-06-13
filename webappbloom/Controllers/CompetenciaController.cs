using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.Controllers;
public class CompetenciaController:Controller{

public IActionResult Index(){

    Competencia competencia = new Competencia();
    competencia.ColunaBloom = "Memoriza";
    competencia.LinhaBloom = "Compreender";
    ViewData["titulo"] = "entender o funcionamento do Razor"; //posso puxar esta mensagem de qualquer lugar usando somente [competencia].
    ViewData["tablebloom"] = competencia;
    return View();
}

}
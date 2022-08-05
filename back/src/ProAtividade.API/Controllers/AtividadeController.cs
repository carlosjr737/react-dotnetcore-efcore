using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Models;

namespace ProAtividade.API.Controllers
{
    [Route("api/[controller]")]
    public class AtividadeController : Controller
    {
       [HttpGet]
       public Atividade Get(){
        return new Atividade();
       }
        [HttpPost]
       public string Post(){
        return "teste";
       }

    [HttpPut]
       public string Pul(){
        return "teste";
       }

    [HttpDelete]
       public string Delete(){
        return "teste";
       }
    }
}
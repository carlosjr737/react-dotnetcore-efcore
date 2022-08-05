using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Models;

namespace ProAtividade.API.Controllers
{
    [Route("api/[controller]")]
    public class ControllerApi : Controller
    {      
       [HttpGet]
       public Atividade get(){
        return new Atividade();
       }   

        [HttpGet("{id}")]
       public string get(int id){
        return $"meu primeiro get com primeiro parametro = {id}";
       }   
       
       
       [HttpPost]
       public string Post(){
        return "meu primeiro Post";
       }   
       
       [HttpPut("{id}")]
       public string Put(int id){   
        return "meu primeiro Put";
       }   
       
       [HttpDelete("{id}")]
       public string Delete(int id){
        return "meu primeiro Delete";
       }
    }
}
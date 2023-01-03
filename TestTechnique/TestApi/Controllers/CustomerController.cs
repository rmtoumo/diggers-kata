using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly TestApiDbContext _testApiDbContext;
        public CustomerController(TestApiDbContext testApiDbContext)
        {
            _testApiDbContext = testApiDbContext;
        }
       

        // Implémenter une route qui a partir d'un id client renvoie le nom, le prénom et l'adresse email du client
        // RG: 
            // Si le client n'est pas présent, la route doit renvoyer le résultat MVC approprié
            // L'implémentation doit être asynchrone
            // Il ne faut pas retourner l'entité directement, mais créer une méthode d'extension qui renvoie une DTO avec les données demandées

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            throw new NotImplementedException();
        }



        // Implémenter une route qui va récupérer la liste des clients [{nom, prénom, email}] ayant acheté un produit avec l'id donné en entré
        // RG: 
            // Si il n'y a pas de résultats, la route doit renvoyer le résultat MVC approprié
            // L'implémentation doit être asynchrone
            // Il ne faut pas retourner l'entité directement, mais créer une méthode d'extension qui renvoie une DTO avec les données demandées
        [HttpGet("GetCustomersByProductId/{id}")]
        public IActionResult GetCustomersByProductId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
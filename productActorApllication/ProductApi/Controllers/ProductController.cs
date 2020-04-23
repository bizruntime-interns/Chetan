using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using ProductActorService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route(template:"api/[controller]")]
    public class ProductController:Controller
    {
        [HttpGet]
        public async Task<Product> GetProductById(
            [FromQuery] int id)
        {
            var actorId = new ActorId(id);
            var proxy = ActorProxy.Create<IProductActorService>(actorId, new Uri(" fabric:/productActorApllication/ProductActorServiceActorService"));
            var product = await proxy.GetProductAsync(new CancellationToken());
            return product;
        }

        [HttpPost]
        public async Task AddProduct(
           [FromBody] Product product)
        {
            var actorId = new ActorId(product.Id);
            var proxy = ActorProxy.Create<IProductActorService>(actorId, new Uri(" fabric:/productActorApllication/ProductActorServiceActorService"));
            await proxy.AddProductAsync(product, new CancellationToken());
        }

        [HttpDelete]
        public async Task DeleteActorById(
            [FromQuery] int id)
        {
            var actorId= new ActorId(id);
            var actorServiceProxy = ActorServiceProxy.Create(new Uri(" fabric:/productActorApllication/ProductActorServiceActorService"),
                actorId);

            await actorServiceProxy.DeleteActorAsync(actorId, new CancellationToken());
        }
    }
}

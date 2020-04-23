using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Communication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace CommunicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommunicationController : ControllerBase
    {
        [HttpGet]
        [Route("stateless")]
        public async Task<string> StatelessGet()
        {
            var statelessProxy = ServiceProxy.Create<IStatelessInterface>(
                new Uri("fabric:/JumpStartStore/CustomerAnalytics"));

            var serviceName = await statelessProxy.GetServiceDetails();

            return serviceName;
        }

        [HttpGet]
        [Route("statefull")]
        public async Task<string> StatefullGet(
            [FromQuery] int productId)
        {
            var partitionId = productId % 3;
            var statefullProxy = ServiceProxy.Create<IStatefullInterface>(
                new Uri("fabric:/JumpStartStore/ProductCatelog"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(partitionId));

            var serviceName = await statefullProxy.GetServiceDetails();

            return serviceName;
        }

        [HttpPost]
        [Route("addproduct")]
        public async Task AddProductt(
            [FromQuery] Product product)
        {
            var partitionId = product.Id % 3;

            var statefullProxy = ServiceProxy.Create<IStatefullInterface>(
                new Uri("fabric:/JumpStartStore/ProductCatelog"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(partitionId));

            await statefullProxy.AddProductt(product);
        }

        [HttpGet]
        [Route("getproduct")]
        public async Task<Product> GetProductt(
            [FromQuery] int productId)
        {
            var partitionId = productId % 3;
            var statefullProxy = ServiceProxy.Create<IStatefullInterface>(
                new Uri("fabric:/JumpStartStore/ProductCatelog"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(partitionId));

            var product = await statefullProxy.GetProducttById(partitionId);

            return product;
        }

        [HttpPost]
        [Route("addtoqueue")]
        public async Task AddToQueue(
            [FromQuery] int partitionId,
            [FromQuery] Product product)
        {


            var statefullProxy = ServiceProxy.Create<IStatefullInterface>(
                new Uri("fabric:/JumpStartStore/ProductCatelog"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(partitionId));

            await statefullProxy.AddToQueue(product);

        }

        [HttpGet]
        [Route("getfromqueue")]
        public async Task<Product> GetFromQueue(
            [FromQuery] int partitionId)
        {
            var statefullProxy = ServiceProxy.Create<IStatefullInterface>(
                new Uri("fabric:/JumpStartStore/ProductCatelog"),
                new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(partitionId));

            var product = await statefullProxy.GetFromQueue();

            return product;
        }
    }
}

using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading.Tasks;
using System;

namespace Communication
{
    public interface IStatefullInterface:IService
    {
        Task<string> GetServiceDetails();
        Task<Product> GetProducttById(int id);
        Task AddProductt(Product product);
        Task<Product> GetFromQueue();
        Task AddToQueue(Product product);
    }
}

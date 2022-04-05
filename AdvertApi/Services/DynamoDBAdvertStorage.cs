using AdvertApi.Models;
using System.Threading.Tasks;

namespace AdvertApi.Services
{
    public class DynamoDBAdvertStorage : IAdvertStorageService
    {
        public Task<string> Add(AdvertModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Confirm(ConfirmAdvertModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}

using TestApiApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestApiApp.Services
{
    public class RequestManager
    {
        IRestService restService;
        public RequestManager(IRestService service)
        {
            restService = service;
        }
        public Task<List<EntryModel>> GetEntrieModels()
        {
            return restService.GetDataAsync();
        }
    }
}

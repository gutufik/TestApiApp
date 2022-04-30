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
        public Task<List<Cat>> GetCats()
        {
            return restService.GetTodoItemAsync();
        }

        public Task DeleteTodoAsync(Cat item)
        {
            return restService.DeleteTodoItemAsync(item);
        }
        public Task SaveItemAsync(Cat todoItem, bool isNewItem = false)
        {
            return restService.SaveTodoItemAsync(todoItem, isNewItem);
        }
    }
}

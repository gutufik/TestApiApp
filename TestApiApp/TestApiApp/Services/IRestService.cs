using System;
using System.Collections.Generic;
using System.Text;
using TestApiApp.Models;
using System.Threading.Tasks;

namespace TestApiApp.Services
{
    public interface IRestService
    {
        Task<List<Cat>> GetTodoItemAsync();
        Task SaveTodoItemAsync(Cat cat, bool isNewItem);
        Task DeleteTodoItemAsync(Cat cat);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TestApiApp.Models;
using System.Threading.Tasks;

namespace TestApiApp.Services
{
    public interface IRestService
    {
        Task<WeatherRoot> GetWeatherAsync(string city);
    }
}

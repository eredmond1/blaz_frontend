using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public class StockService
    {
        private readonly HttpClient _httpClient;

        public StockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Stock>?> GetStocksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Stock>>("api/stock");
        }

        public async Task<Stock> AddStockAsync(Stock stock)
        {
            var response = await _httpClient.PostAsJsonAsync("api/stock", stock);

            if(response.IsSuccessStatusCode)
            {
                var result =  await response.Content.ReadFromJsonAsync<Stock>();
                if(result  ==  null)
                {
                    throw new Exception("the api could not prossess the data");
                }

                return result;
            }
            else
            {
        // Handle errors (e.g., throw an exception or return a default value)
                throw new Exception($"Failed to add stock: {response.ReasonPhrase}");
            }
        }


        public async Task<Stock> UpdateStockAsync(int ID, Stock stock){
            var response = await _httpClient.PutAsJsonAsync($"api/stock/{ID}",stock);

            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<Stock>();
                if(result == null)
                {
                    throw new Exception("the api could not process the data");
                }
                return result;

            }
            else
            {
                throw new Exception($"Failed to add stock: {response.ReasonPhrase}");
            }
        }
    }
}
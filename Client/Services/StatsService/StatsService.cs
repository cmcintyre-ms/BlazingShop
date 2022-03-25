using Blazored.LocalStorage;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient http;
        private readonly ILocalStorageService localStorage;

        public StatsService(HttpClient http, ILocalStorageService localStorage)
        {
            this.http = http;
            this.localStorage = localStorage;
        }

        public async Task GetVisits()
        {
            int visits = int.Parse(await http.GetStringAsync("api/Stats"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisits()
        {
            DateTime? lastVisit = await localStorage.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await http.PostAsync("api/Stats", null);
            }
        }  
    }
}

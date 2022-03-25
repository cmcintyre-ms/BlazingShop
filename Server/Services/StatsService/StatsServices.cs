using BlazingShop.Client.Pages;
using BlazingShop.Server.Data;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.StatsService
{
    public class StatsServices : IStatsService
    {
        private readonly DataContext context;

        public StatsServices(DataContext context)
        {
            this.context = context;
        }

        public async Task<int> GetVisits()
        {
            var stats = await context.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                return 0;
            }
            return stats.Visits;
        }

        public async Task IncrementVisits()
        {
            var stats = await context.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                context.Stats.Add(new Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visits++;
                stats.LastVisit = DateTime.Now;
            }

            await context.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Io;
using FreeGameIsAFreeGame.Core;
using FreeGameIsAFreeGame.Core.Models;
using NLog;

namespace FreeGameIsAFreeGame.Scraper.GamesWithGold
{
    public class GamesWithGoldScraper : IScraper
    {
        private const string URL = "https://www.xbox.com/en-US/live/gold/js/gwg-globalContent.js";
        private IBrowsingContext context;
        private ILogger logger;

        string IScraper.Identifier => "GamesWithGold";

        /// <inheritdoc />
        public Task Initialize()
        {
            context = BrowsingContext.New(Configuration.Default
                .WithDefaultLoader()
                .WithDefaultCookies());

            logger = LogManager.GetLogger(GetType().FullName);
            
            return Task.CompletedTask;
        }

        async Task<IEnumerable<IDeal>> IScraper.Scrape(CancellationToken token)
        {
            List<IDeal> deals = new List<IDeal>();

            string content = await GetContent(token);
            token.ThrowIfCancellationRequested();

            GamesWithGoldGlobalContent globalContent = GamesWithGoldGlobalContent.FromJson(content);
            GamesLocale locale = globalContent.Locales["en-us"];
            for (int i = 0; i < 8; i++)
            {
                GamesWithGoldContent gameContent = locale.ToGamesWithGoldContent(i + 1);
                if (string.IsNullOrEmpty(gameContent.Dates))
                    continue;

                GetDates(gameContent.Dates, out DateTime startDate, out DateTime endDate);
                deals.Add(new Deal()
                {
                    Discount = 100,
                    Title = gameContent.Title,
                    Link = gameContent.Link,
                    Image = gameContent.Image,
                    Start = startDate,
                    End = endDate
                });
            }

            return deals;
        }

        private async Task<string> GetContent(CancellationToken token)
        {
            Url url = Url.Create(URL);
            DocumentRequest request = DocumentRequest.Get(url);
            IDocument document = await context.OpenAsync(request, token);
            if (token.IsCancellationRequested)
                return null;

            string content = document.Body.Text();
            content = content.Substring(content.IndexOf('{'));
            content = content.Substring(0, content.IndexOf("globalContentOld")).Trim();
            return content;
        }

        private void GetDates(string input, out DateTime startDate, out DateTime endDate)
        {
            string[] dates = input.Split("–");
            startDate = DateTime.Parse(dates[0].Trim());
            endDate = DateTime.Parse(dates[1].Trim());
            if (endDate > startDate)
                return;

            DateTime now = DateTime.Now;
            if (now <= startDate)
            {
                endDate = endDate.AddYears(1);
            }
            else if (now >= endDate)
            {
                startDate = startDate.AddYears(-1);
            }
            else if (now.Month >= startDate.Month)
            {
                endDate = endDate.AddYears(1);
            }
            else if (now.Month <= endDate.Month)
            {
                startDate = startDate.AddYears(-1);
            }
        }

        /// <inheritdoc />
        public Task Dispose()
        {
            context?.Dispose();
            return Task.CompletedTask;
        }
    }
}

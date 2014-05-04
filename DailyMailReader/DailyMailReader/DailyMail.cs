using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DailyMailReader
{
    public class DailyMail
    {
        private HttpClient httpClient;

        private string latestHeadlines = "http://www.dailymail.co.uk/api/latest_headlines/home/{0}.json";

        public DailyMail()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<DailyMailArticle>> LatestHeadlines (int start = 0)
        {
            var json = await httpClient.GetStringAsync(new Uri(string.Format(latestHeadlines, start)));

            var headlines = JsonConvert.DeserializeObject<List<DailyMailArticle>>(json);

            return headlines;
        }
    }
}

using Newtonsoft.Json;
using System.Net;

namespace GetUsdRate
{
    public static class GetUsdRate
    {
        public static HttpClient _client;

        public static async Task<double> ConvertToUSD(string priceUAH)
        {
            try
            {
                double usdRate = await GetUsdRateAPI();

                if (double.TryParse(priceUAH, out double priceUAHDecimal))
                {
                    double priceUSD = priceUAHDecimal / usdRate;
                    return priceUSD;
                }
                else
                {
                    throw new ArgumentException("Неверный формат цены в UAH");
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine($"Ошибка при конвертации цены: {e.Message}");
                return 0;
            }
        }

        private static async Task<double> GetUsdRateAPI()
        {
            double rate = 0;
            try
            {
                HttpResponseMessage response;
                string responseBody = string.Empty;
                response = await _client.GetAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    responseBody = response.Content.ReadAsStringAsync().Result;
                    dynamic usd = JsonConvert.DeserializeObject<dynamic>(responseBody);
                    //decimal rate;
                    foreach (var line in usd)
                    {
                        if (line.ccy == "USD")
                        {
                            //Console.WriteLine(line.buy);
                            string str = line.buy;
                            str = str.Replace('.', ',');
                            rate = double.Parse(str);
                        }
                    }
                }
                
                //HttpResponseMessage response = await _client.GetAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");

                //response.EnsureSuccessStatusCode();

                //string responseBody = await response.Content.ReadAsStringAsync();

                //string[] lines = responseBody.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                //foreach (string line in lines)
                //{
                //    if (line.Contains("USD"))
                //    {
                //        string[] parts = line.Split(':');
                //        if (parts.Length >= 5)
                //        {
                //            string rateString = parts[4].Trim().Replace(',', '.');
                //            if (decimal.TryParse(rateString, out rate))
                //                return rate;
                //        }
                //    }
                //}
                //throw new Exception("Курс USD не найден в ответе API.");
            }
            catch (Exception)
            {
                
            }
            return rate;
        }


    }
}

namespace GetUsdRate
{
    public static class GetUsdRate
    {
        public static HttpClient _client;

        public static async Task<decimal> ConvertToUSD(string priceUAH)
        {
            try
            {
                decimal usdRate = await GetUsdRateAPI();

                if (decimal.TryParse(priceUAH, out decimal priceUAHDecimal))
                {
                    decimal priceUSD = priceUAHDecimal / usdRate;
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

        private static async Task<decimal> GetUsdRateAPI()
        {
            decimal rate = 0;
            try
            {
                HttpResponseMessage response = await _client.GetAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                string[] lines = responseBody.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (line.Contains("USD"))
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length >= 5)
                        {
                            string rateString = parts[4].Trim().Replace(',', '.');
                            if (decimal.TryParse(rateString, out rate))
                                return rate;
                        }
                    }
                }
                //throw new Exception("Курс USD не найден в ответе API.");
            }
            catch (HttpRequestException e)
            {
                
            }
            return 0;
        }


    }
}

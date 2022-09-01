namespace CV19Console
{
    internal class Program
    {
        const string data_url = @"https://github.com/CSSEGISandData/COVID-19/blob/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";

        static void Main(string[] args)
        {
            var client = new HttpClient();

            var response = client.GetAsync(data_url).Result;
            var csv_string = response.Content.ReadAsStringAsync().Result;
            Console.ReadLine();
        }
    }
}
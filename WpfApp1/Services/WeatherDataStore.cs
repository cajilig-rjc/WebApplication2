using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    public class WeatherDataStore:RestBase
    {

        public async Task<IEnumerable<WeatherForecast>> WeatherForecasts()
        {
            
            try
            {
                HttpResponseMessage response = await HttpGetAsync("weatherforecast");
                if ((int)response.StatusCode == 200)
                {
                   return JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (HttpRequestException ex)
            {               
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {               
                throw new Exception(ex.Message);
            }
          
        }
    }
}

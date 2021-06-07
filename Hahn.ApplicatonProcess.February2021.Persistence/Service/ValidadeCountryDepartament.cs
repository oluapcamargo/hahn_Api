using Hahn.ApplicatonProcess.February2021.Domain.Entity.Others;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Service
{
    public class ValidadeCountryDepartament
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly String URL = "https://restcountries.eu/rest/v2/name/";
        private static readonly String FILTER = "?fields=name";

        public ValidadeCountryDepartament(){}

        public async Task<string> GetCountryDepartament(string countryDepartament) 
        {
            var response = await client.GetAsync(URL + countryDepartament+ FILTER);
            var stream = await response.Content.ReadAsStringAsync();
            RestCountriesResponse countryObject = JsonConvert.DeserializeObject<RestCountriesResponse>(stream.Replace("[","").Replace("]", ""));
            return countryObject.name;
        }
    }
}

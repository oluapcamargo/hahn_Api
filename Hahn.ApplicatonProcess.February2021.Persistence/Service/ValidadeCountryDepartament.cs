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


        public ValidadeCountryDepartament(){}

        public async Task<string> GetCountryDepartament(string countryDepartament) 
        {
            var response = await client.GetAsync(URL + countryDepartament);
            using var stream = await response.Content.ReadAsStreamAsync();
            return "";
        }
    }
}

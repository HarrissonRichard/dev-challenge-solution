using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using RestCountriesChallenge.Models;

namespace RestCountriesChallenge.DataAccess
{
    public interface ICountryData
    {
        [Get("/all?fields=name,capital,region,subregion,population,area,flags,timezones")]
        Task<List<CountryModel>> GetAllCountries();
    }
}
 
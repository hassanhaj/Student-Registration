using Microsoft.EntityFrameworkCore;
using StudentRegistration.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Web.Services
{
    public class CountryService
    {
        private readonly RegistrationContext _context;

        public CountryService(RegistrationContext context)
        {
            _context = context;
        }
        public IEnumerable<Country> GetCountries()
        {
            return _context.Countries.ToArray();
        }
        public async Task<IEnumerable<Country>> GetCountriesAsync()
        {
            return await _context.Countries.ToArrayAsync();
        }
    }
}

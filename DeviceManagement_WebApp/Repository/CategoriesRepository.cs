using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository
    {

        public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
        {
            public CategoriesRepository(ConnectedOfficeContext context) : base(context)
            {
            }

            public Category GetMostRecentService()
            {
                return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
            }
        }

      

    }





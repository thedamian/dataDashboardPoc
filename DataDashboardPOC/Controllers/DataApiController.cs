using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataDashboardPOC.Models;
using DataDashboardPOC.Repositories;

namespace DataDashboardPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataApiController : ControllerBase
    {

        private IDataRepository dataRepo;

        public DataApiController(IDataRepository _dataRepo)
        {
           dataRepo = _dataRepo;
        }

        // GET: api/DataApi
        [HttpGet]
        public List<InsuranceTime> Get()
        {
            return dataRepo.GetInsuranceTimes(5);
        }

    }
}

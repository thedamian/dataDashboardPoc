using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDashboardPOC.Models;

namespace DataDashboardPOC.Repositories
{
    public interface IDataRepository
    {
        List<InsuranceTime> GetInsuranceTimes(int NumOfTimes);
    }

    public class DataRepository : IDataRepository
    {

        public List<InsuranceTime> GetInsuranceTimes(int NumOfTimes)
        {
            List<InsuranceTime> insuranceTimes = new List<InsuranceTime>();

            Random rnd = new Random();
            for (int i = 0; i < NumOfTimes; i++)
            {
                InsuranceTime insuranceTime = new InsuranceTime();
                insuranceTime.Time = "10:" + (i * 10).ToString();
                insuranceTime.Insu_A = rnd.Next(1, 50);
                insuranceTime.Insu_B = rnd.Next(1, 50);
                insuranceTime.Insu_C = rnd.Next(1, 50);
                insuranceTimes.Add(insuranceTime);
            }
            return insuranceTimes;

        }

    }
}

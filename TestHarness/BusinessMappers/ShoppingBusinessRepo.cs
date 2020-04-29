using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace TestHarness
{
    public class ShopingBusinessRepo
    {

        private const string CreateOrUpdateSP = "sp_CreateOrUpdateCustometr";
        public int Create(Customer cust)
        {
            ShopingDataContext context = new ShopingDataContext();
            var res = Convert.ToInt32(context.executeScaler<decimal>(CreateOrUpdateSP, customerParamsBuilder(cust)));
            return res;
        }

        private SqlParameter[] customerParamsBuilder(Customer cust)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                

                new SqlParameter("@Id",cust.Id),
                new SqlParameter("@FirstName",cust.FirstName),
                new SqlParameter("@LastName",cust.LastName),
                new SqlParameter("@City",cust.City),
                new SqlParameter("@Country",cust.Country),
                new SqlParameter("@phone",cust.Phone),

            };
            return param;
        }
        

    }
}



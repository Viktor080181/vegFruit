using db_vegetables_and_fruits.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace db_vegetables_and_fruits.Services
{

    public class VegFruitServices

    {
        public bool ADDFruit(VegFruit db_vegetables_and_fruits)
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                dbConnection.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }
            return false;
        }
    }
}



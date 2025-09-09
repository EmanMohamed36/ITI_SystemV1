using session01.Data;

namespace session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1
            //CompanyDbContext context = new CompanyDbContext();
            //try
            //{

            //}
            //finally
            //{ 
            //    context.Dispose();
            //}

            #endregion

            #region V2
            //using (CompanyDbContext context = new CompanyDbContext())
            //{ 
            //    //some code
            //}

            #endregion

            #region V3

            using CompanyDbContext context = new CompanyDbContext() ;
           //  context.Employees.Where(e=> e.ID = 1).FirstOrDefault();

                    
                    
            #endregion

        }
    }
}

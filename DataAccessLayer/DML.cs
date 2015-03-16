using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    /// <summary>
    /// Contains all methods for modeling the database. Use this one for all access.
    /// </summary>
     class DML
    {

        // properties, varible, instanziation
        #region
        
        private static DML _instance = new DML();

         //TODO remember to edit this to datadirectory later on, on release. also change this to your specifik database path when doin dev work.
        private string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\mikkel\Documents\4s projekt\Gruppe8\DataAccessLayer\Database01.mdf;Integrated Security=True";
        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        #endregion

         //maybe delegates area
        #region
         
        #endregion

        //Singleton pattern for the database
        #region
        private DML()
        {
            
        }

        public static DML GetInstance()
        {
            return _instance;
        }

        #endregion



         //createRegion
        #region
        public bool CreateNewMedarbejder(string name, string initials)
        {
            connection.ConnectionString = connectionstring;
            

        }



        public bool CreateNewModel(string model, string brand)
        {
            connection.ConnectionString = connectionstring;


        }


         //TODO Discuss method overload over delegates
        public bool CreateNewComputer()
        {
            connection.ConnectionString = connectionstring;


        }

        public bool CreateNewMus()
        {
            connection.ConnectionString = connectionstring;
        }

        public bool CreateNewTestEnheder()
        {
            connection.ConnectionString = connectionstring;
        }

        public bool CreateNewTlf()
        {
            connection.ConnectionString = connectionstring;
        }

        public bool CreateNewOvrigHardware()
        {
            connection.ConnectionString = connectionstring;
        }



        #endregion

        //updateRegion
        #region

        public bool UpdateMedarbejder(string name, string initials, string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateModel(string model, string brand, string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateComputer(string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateMus(string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateTestEnheder(string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateTlf(string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateOvrigHardware(string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        #endregion

        //deleteRegion
        #region

        public bool DeleteMedarbejder(string name, string initials)
        {
            connection.ConnectionString = connectionstring;


        }


        public bool DeleteModel(string model, string brand)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteComputer()
        {
            connection.ConnectionString = connectionstring;


        }


        public bool DeleteMus()
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteTestEnheder()
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteTlf()
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteOvrigHardware()
        {
            connection.ConnectionString = connectionstring;


        }

        #endregion

       
    }
}

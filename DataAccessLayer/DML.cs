using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;

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
        public bool CreateNewMedarbejder(Employee employee)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }



        public bool CreateNewModel(string model, string brand)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }


        //TODO Sørg for at der bliver implementeret modelklasser fra logic



        public bool CreateNewComputer(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        

        public bool CreateNewMus(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        public bool CreateNewTestEnheder(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        public bool CreateNewTlf(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        public bool CreateNewOvrigHardware(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }



        #endregion

        //updateRegion
        #region

        public bool UpdateMedarbejder(Employee employee, string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateModel(string model, string brand, string newinfo)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateComputer(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateMus(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateTestEnheder(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateTlf(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool UpdateOvrigHardware(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        #endregion

        //deleteRegion
        #region

        public bool DeleteMedarbejder(Employee employee)
        {
            connection.ConnectionString = connectionstring;


        }


        public bool DeleteModel(string model, string brand)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteComputer(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }


        public bool DeleteMus(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteTestEnheder(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteTlf(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        public bool DeleteOvrigHardware(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        #endregion

       
    }
}

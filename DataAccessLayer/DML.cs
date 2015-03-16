using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        private delegate bool CreateHardwaredelegate(Hardware hardware);
        private delegate bool UpdateHardwareDelegate(Hardware hardware);
        private delegate bool DeleteHardwareDelegate(Hardware hardware);

        private CreateHardwaredelegate newhardware;
        private UpdateHardwareDelegate updatehwd;
        private DeleteHardwareDelegate Deletehwd;


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



        public bool CreateNewHardware(Hardware hardware)
        {

            switch (hardware.HardwareName)
            {
                case "computer":
                    newhardware = CreateNewComputer;
                    newhardware(hardware);
                    
                    break;

                case "mus":
                    newhardware = CreateNewMus;
                    newhardware(hardware);
                    break;

                case "testenheder":
                    newhardware = CreateNewTestEnheder;
                    newhardware(hardware);
                    break;

                case "tlf":
                    newhardware = CreateNewTlf;
                    newhardware(hardware);
                    break;

                case "ovrighardware":
                    newhardware = CreateNewOvrigHardware;
                    newhardware(hardware);
                    break;

                default:
                    return false;
                    break;
            }


           

        }




        private bool CreateNewComputer(Hardware hardware)
        {

            connection.ConnectionString = connectionstring;
            
            return false;
        }

        

        private bool CreateNewMus(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        private bool CreateNewTestEnheder(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        private bool CreateNewTlf(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;

            return false;
        }

        private bool CreateNewOvrigHardware(Hardware hardware)
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


        public bool UpdateHardware(Hardware hardware)
        {
            switch (hardware.HardwareName)
            {
                case "computer":
                    updatehwd = UpdateComputer;
                    updatehwd(hardware);
                    break;

                case "mus":
                    updatehwd = UpdateMus;
                    updatehwd(hardware);
                    break;

                case "testenheder":
                    updatehwd = UpdateTestEnheder;
                    updatehwd(hardware);
                    break;

                case "tlf":
                    updatehwd = UpdateTlf;
                    updatehwd(hardware);
                    break;

                case "ovrighardware":
                    updatehwd = UpdateOvrigHardware;
                    updatehwd(hardware);
                    break;

                default:
                    return false;
                    break;
            }
        }

        private bool UpdateComputer(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool UpdateMus(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool UpdateTestEnheder(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool UpdateTlf(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool UpdateOvrigHardware(Hardware hardware)
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


        public bool DeleteHardware(Hardware hardware)
        {
            switch (hardware.HardwareName)
            {
                case "computer":
                    Deletehwd = DeleteComputer;
                    Deletehwd(hardware);

                    break;

                case "mus":
                    Deletehwd = DeleteMus;
                    Deletehwd(hardware);
                    break;

                case "testenheder":
                    Deletehwd = DeleteTestEnheder;
                    Deletehwd(hardware);
                    break;

                case "tlf":
                    Deletehwd = DeleteTlf;
                    Deletehwd(hardware);
                    break;

                case "ovrighardware":
                    Deletehwd = DeleteOvrigHardware;
                    Deletehwd(hardware);
                    break;

                default:
                    return false;
                    break;
            }
        }



        private bool DeleteComputer(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }


        private bool DeleteMus(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool DeleteTestEnheder(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool DeleteTlf(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        private bool DeleteOvrigHardware(Hardware hardware)
        {
            connection.ConnectionString = connectionstring;


        }

        #endregion

       
    }
}

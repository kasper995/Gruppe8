using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Inventory;

namespace Logic
{
    class DatabaseLogic
    {

        private DML DMLInstance = DML.GetInstance();


        #region // Employee methods
        public void Createnewemloyee(string firstname, string lastname, string initialer)
        {
            DMLInstance.CreateNewMedarbejder(new Employee() {FirstName = firstname, LastName = lastname, Initialer = initialer});
        }
        public void Updatenewemloyee(string firstname, string lastname, string initialer)
        {
            DMLInstance.UpdateMedarbejder(new Employee() { FirstName = firstname, LastName = lastname, Initialer = initialer });
        }
        public void Delelteemployee(string firstname, string lastname, string initialer)
        {
            DMLInstance.DeleteMedarbejder(new Employee() { FirstName = firstname, LastName = lastname, Initialer = initialer });
        }
        #endregion

        #region // Computer methods
       
        public void UpdatenewComputer(string name)
        {
            DMLInstance.UpdateHardware(new Computer() {});
        }
      
        #endregion
    }
}

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

        private readonly DML _dmlInstance = DML.GetInstance();


        #region // Employee methods
        public void Createnewemloyee(string firstname, string lastname, string initialer)
        {
            _dmlInstance.CreateNewMedarbejder(new Employee() {FirstName = firstname, LastName = lastname, Initialer = initialer});
        }
        public void Updatenewemloyee(string firstname, string lastname, string initialer)
        {
            _dmlInstance.UpdateMedarbejder(new Employee() { FirstName = firstname, LastName = lastname, Initialer = initialer });
        }
        public void Delelteemployee(string firstname, string lastname, string initialer)
        {
            _dmlInstance.DeleteMedarbejder(new Employee() { FirstName = firstname, LastName = lastname, Initialer = initialer });
        }
        #endregion

        #region // Computer methods
        public void CreateNewComputer(string name)
        {
            _dmlInstance.CreateNewHardware(new Computer() { });
        }
        public void UpdatenewComputer(string name)
        {
            _dmlInstance.UpdateHardware(new Computer() {});
        }
        public void DeleteNewComputer(string name)
        {
            _dmlInstance.DeleteHardware(new Computer() { });
        }
        #endregion
    }
}

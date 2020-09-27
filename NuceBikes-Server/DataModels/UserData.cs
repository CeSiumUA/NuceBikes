using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class UserData:User
    {
        #region Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                secondName = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        #endregion
        #region Fields
        private string firstName { get; set; }
        private string secondName { get; set; }
        private string description { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        #region Properties
        public string UseName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public Password Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        #endregion
        #region Fields
        private string userName { get; set; }
        private Password password { get; set; }
        #endregion
    }
}

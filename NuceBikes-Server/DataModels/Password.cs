using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class Password
    {
        [Key]
        public int Id { get; set; }
        #region Properties
        public string PasswordHash
        {
            get
            {
                return passwordHash;
            }
            set
            {
                passwordHash = value;
            }
        }
        #endregion
        #region Fields
        private string passwordHash { get; set; }
        #endregion
    }
}

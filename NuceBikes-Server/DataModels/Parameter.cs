using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class Parameter
    {
        [Key]
        public int Id { get; set; }
        public string ParameterName
        {
            get
            {
                return parametername;
            }
            set
            {
                parametername = value;
            }
        }
        public string ParameterValue
        {
            get
            {
                return parametervalue;
            }
            set
            {
                parametervalue = value;
            }
        }
        public Bike Bike
        {
            get
            {
                return bike;
            }
            set
            {
                bike = value;
            }
        }
        private string parametername { get; set; }
        private string parametervalue { get; set; }
        private Bike bike { get; set; }
    }
}

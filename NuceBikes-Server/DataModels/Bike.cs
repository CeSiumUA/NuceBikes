using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuceBikes_Server.DataModels
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }
        #region Properties
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string? Modification
        {
            get
            {
                return modification;
            }
            set
            {
                modification = value;
            }
        }
        public BikeType BikeType
        {
            get
            {
                return bikeType;
            }
            set
            {
                bikeType = value;
            }
        }
        public string PhotoUrl
        {
            get
            {
                return photoUrl;
            }
            set
            {
                photoUrl = value;
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
        private string manufacturer { get; set; }
        private string model { get; set; }
        private string modification { get; set; }
        private BikeType bikeType { get; set; }
        private string photoUrl { get; set; }
        private string description { get; set; }
        #endregion
    }
    public enum BikeType : int
    {
        MTB = 0,
        Gravel,
        Road,
        BMX,
        CycloCross,
        City,
        Kids
    }
}

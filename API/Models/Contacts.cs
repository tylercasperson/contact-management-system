using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManagementSystemwebAPI.Models
{
    public class Contacts
    {
        public int id { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime birthdate { get; set; }
        public int contactGroupID { get; set; }
        public string description { get; set; }
        public bool favoriteFlag { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}

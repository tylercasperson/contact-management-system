using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManagementSystemwebAPI.Models
{
    public class ContactGroups
    {
        public int id { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}

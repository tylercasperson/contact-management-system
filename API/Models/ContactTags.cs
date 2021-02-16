using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManagementSystemwebAPI.Models
{
    public class ContactTags
    {
        public int id { get; set; }
        public int contactID { get; set; }
        public int tagID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

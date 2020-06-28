namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public long ID { get; set; }

        public string Name { get; set; }

        [StringLength(200)]
        public string Designation { get; set; }

        [StringLength(200)]
        public string Location { get; set; }
    }
}

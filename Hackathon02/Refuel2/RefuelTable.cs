namespace Hackathon02.Refuel2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RefuelTable")]
    public partial class RefuelTable
    {
        public int Id { get; set; }

        public DateTime RefuelingDate { get; set; }

        public double Liter { get; set; }

        public double Kilometer { get; set; }
    }
}

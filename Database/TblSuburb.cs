using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RealEstate.Database
{
    [Table("tblSuburb")]
    public partial class TblSuburb
    {
        public TblSuburb()
        {
            TblProperties = new HashSet<TblProperty>();
        }

        [Key]
        [Column("SuburbID")]
        public long SuburbId { get; set; }
        [StringLength(30)]
        public string Suburb { get; set; }
        [StringLength(10)]
        public string State { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [Column("Min_Bed_Room")]
        public int? MinBedRoom { get; set; }
        [Column("Max_Bed_Room")]
        public int? MaxBedRoom { get; set; }
        [Column("Min_Bathroom")]
        public int? MinBathroom { get; set; }
        [Column("Base_Name")]
        [StringLength(30)]
        public string BaseName { get; set; }
        [Column("Base_Lat")]
        public double? BaseLat { get; set; }
        [Column("Base_Long")]
        public double? BaseLong { get; set; }
        [Column("revenue_per_room_p")]
        public double? RevenuePerRoomP { get; set; }
        [Column("run_cost_weekly")]
        public double? RunCostWeekly { get; set; }
        [StringLength(250)]
        public string AlertRule { get; set; }
        [StringLength(250)]
        public string AlertEmails { get; set; }
        public bool? Active { get; set; }
        [Column("adjustment")]
        public int? Adjustment { get; set; }
        [StringLength(10)]
        public string RentBuy { get; set; }
        [Column("property_type")]
        [StringLength(200)]
        public string PropertyType { get; set; }
        [StringLength(15)]
        public string Source { get; set; }

        [InverseProperty(nameof(TblProperty.Suburb))]
        public virtual ICollection<TblProperty> TblProperties { get; set; }
    }
}

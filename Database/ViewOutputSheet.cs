using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RealEstate.Database
{
    [Keyless]
    public partial class ViewOutputSheet
    {
        [Column("SuburbID")]
        public long? SuburbId { get; set; }
        [StringLength(30)]
        public string Suburb { get; set; }
        [StringLength(10)]
        public string State { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [Column("Walk_Distance")]
        public double? WalkDistance { get; set; }
        [Column("Walk_Time")]
        public double? WalkTime { get; set; }
        [Column("Walk_Score")]
        public double? WalkScore { get; set; }
        [Column("Transit_Score")]
        public double? TransitScore { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(100)]
        public string DescriptionTitle { get; set; }
        [Column("GF_Bedrooms")]
        public int? GfBedrooms { get; set; }
        [Column("GF_Bathrooms")]
        public int? GfBathrooms { get; set; }
        public int? Toilets { get; set; }
        [Column("URL")]
        [StringLength(100)]
        public string Url { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerDatabase.Models
{
    /// <summary>
    /// Big class containing different attributes
    /// </summary>
    public class Computer
    {
        [Key]
        public int ComputerId { get; set; }

        [StringLength(50, MinimumLength = 2), Required]
        public string Name { get; set; }

        [Column("Warrenty")]
        public int WarrentyYears { get; set; }

        [Column("Purchased"), DataType(DataType.Date)]
        public DateTime DatePurchased { get; set; }

        public bool HasCooling { get; set; }

        [Required, StringLength(30), DataType(DataType.Currency)]
        public double Price { get; set; }

        [NotMapped]
        public List<string> Ignore { get; set; }


    }
}

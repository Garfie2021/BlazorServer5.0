using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Model.DB
{
    [Table("TableA")]
    public class TableA
    {
        /// <summary>
        /// ID
        /// </summary>
        [Column("Id")]
        public long Id { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [Column("value")]
        public string Value { get; set; }

    }
}
